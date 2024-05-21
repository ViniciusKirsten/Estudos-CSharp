
using System.Drawing;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular; //privando o objeto
        public int Agencia { get; set; } //quando eu utilizo nesse formato, eu não preciso adiconar
                                         //um parametro um campo privado, pois ele faz isso "por baixo dos panos".
                                         //Isso somente se não houver nenhuma regra no get e set

        public int Numero { get; set; }

        //utilizamos o "_" underline, para mostrar que é um metodo privado
        private double _saldo = 100;  //modificamos a acessibilidade do saldo,
                                      //para que assim nenhuma outra classe
                                      //consiga alterar o saldo de não for
                                      //por um método/função.

        

        //Caso for apenas essa estrutura, sem nenhuma regra,
        //podemos aplicar o método abaixo.
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        //Ex de outra forma para montar, alternativa para o de cima
        public Cliente Titular02 { get; set; }//alternativa simplificada

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set { 
                
                if (value < 0)
                {
                    return;//dessa forma ele para de executar o médodo e volta
                           //para quem fez a chamada do método.
                }
                else
                {
                    _saldo = value; //"value" o meu argumento de entrada.
                }
            }
        }

        //MODO ANTIGO DE FAZER
        /*
        public void SetSaldo(double saldo)  //"Set" no lugar de "Definir"
        {
            if (saldo < 0)
            {
                return;//dessa forma ele para de executar o médodo e volta
                       //para quem fez a chamada do método.
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double GetSaldo() //"Get" no lugar de "Obter"
        {
            return saldo;
        }
        */

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo = valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo = valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
