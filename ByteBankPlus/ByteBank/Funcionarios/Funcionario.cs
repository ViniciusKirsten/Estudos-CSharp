using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario //Colocanco ela como funcionario, ela não pode ser diretamente instanciada.
    {                                 //Pois ela possui o conceito de funcionario, assim todas as outras classes
                                      //possuem a sua particularidade.
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //Assim eu digo que o meu campo está protegido, somente
                                                      //para classe mãe e classes filhos que são manipulaveis

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        /*
         * Quando queremos deixar claro, que vai ter
         * um custo de processamento,vai fazer algo
         * em cima do valor. Quando não é apenas uma
         * lógica.
         */
        public virtual double GetBronificacao()  //Quando adicionamos o "virtual", dentro do nosso metodo
        {                                        //estamos dizendo que ele pode ser alterado modificado 
            return Salario * 0.10;               //uma classe filha.
        }

        //MÉTODOS ABSTRATOS
        /*
         * Utilizamos métodos abstratos, para que assim possamos obrigra sempre sobrescrever o médoto
         * em outra classe, para que não exista a chance do desenvolvedor esquecer de sobrescrever 
         * esse método.
         */
        public abstract void AumentarSalario();
        //Sempre que eu utilizar o "abstract" eu não posso ter um corpo de código para o meu método
        //pois ele sempre vai sobrescrever em outra classe.
    }
}
