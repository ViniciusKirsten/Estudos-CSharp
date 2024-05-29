using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException //referenciando a classe "OperacaoFinanceiraException", na
                                                                          //qual ela vai referenciar a classe "Exceptiom"
    {
        public double Saldo { get; }
        public double ValorSaque { get; }


        //Construtor padrão, por conveção criamos eles sempre
        public SaldoInsuficienteException() { }

        //Construtor que vai receber uma mensagem, assim como o ArgumentException.
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }

        //INNER EXCEPTION
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) { }

        public SaldoInsuficienteException(double saldo, double valorSaque) //Com o "this" estamos chamando o contrutor dessa classe e não da outra
            : this("A tentativa de saque foi "+valorSaque+", com saldo em conta no valor de: "+saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }
    }
}
