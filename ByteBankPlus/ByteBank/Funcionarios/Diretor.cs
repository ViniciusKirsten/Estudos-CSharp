using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    //"Diretor" é uma classe derivada da classe "Funcionario";
    public class Diretor : FuncionarioAutenticavel
    {
        
        public Diretor(double salario,string cpf) : base(salario, cpf) //utilizando o "base", ele vai pegar primeiro o contrutor
        {                                      //da mãe e atribuir o valor (nesse caso o CPF) e depois executar
                                               //o construtor do filho. Obs:Sempre é executado primeiro o construtor filho.
        }
        public override double GetBronificacao() //Está vindo do "virtual" do método da classe mãe,
        {                                        //assim utilizamos o "override" para sobrescrever o
                                                 //comportamento da classe mãe.

            return Salario + base.GetBronificacao();//Utilizando base eu consigo chamar o método que foi
                                                    //definido na classe mãe, assim ele compreende qual
                                                    //método eu quero chamar.
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
