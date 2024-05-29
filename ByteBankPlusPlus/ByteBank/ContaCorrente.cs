// using _05_ByteBank;

using System;
using System.Data;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao {  get; private set; }
        public static int TotalDeContasCriadas { get; private set; }       
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public Cliente Titular { get; set; }

        //forma simplificada para adicionar o "Numero" somente como leitura
        public int Numero { get; }

        /*
        UTILIZANDO A MANIERA ACIMA, O COMPILADOR ENTENDE COMO O CÓDIGO ABAIXO
       
        private readonly int _numero; //Tornando o número somente leitura "readonly"
                                      //dessa maneira, posso apenas atribuir um 
                                      //valor, dentro de um construtor
        public int Numero
        {
            get
            {
                return _numero;
            }
        }
        */
        
        //forma simplificada para adicionar a "Agencia" somente como leitura
        public int Agencia { get; }
        
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento número tem que ser maior que zero.", nameof(agencia)); //"nameof" serve para que caso mude
                                                                                                                //o nome do argumento ele aponte que
                                                                                                                //deve ser mudado dentro do retorno
            }
            if (numero <= 0) 
            { 
                throw new ArgumentException("O argumento número tem que ser maior que zero.", "numero");
            }

            Agencia = agencia;
            Numero = numero;
            
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor do saque negativo", nameof (valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++; 
                //Esse chamado vai levar os dados para o construtor e assim ele vai ser tratado lá dentro
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência ", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }catch (SaldoInsuficienteException e)
            {
                ContadorSaquesNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", e);//Utilizando o Inner Exceptions
            }


            contaDestino.Depositar(valor);
        }
    }
}
