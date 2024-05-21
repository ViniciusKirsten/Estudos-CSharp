using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    /*
     * Esse exwemplo é para que possamos ter um nivel de acesso:
     * Assim a classe "Diretor" vai herdar da classe "Autenticavel"
     * e a classe "Autenticavel" vai herdar da classe "Funcionario".
     */
    public abstract class Autenticavel : Funcionario 
    {
        /*
         * Esse construtor se faz necessário foi o construtor da classe "Funcionario"
         * exige uma entrada, assim a classe que herda da mesma precisa enviar esses
         * dados.
         * 
         * Nesse caso estamos pegando a informação do "Diretor" passando para o construtor
         * da classe "Autenticavel" que passsa a informação para a classe "Funcionario".
         */
        public Autenticavel(double salario, string cpf): base(salario,cpf)
        {

        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
