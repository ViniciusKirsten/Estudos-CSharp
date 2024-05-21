using ByteBank.Funcionarios; //adicionamos o using para ele entender que vamos precisa usar o funcionário
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavelDois funcionario, string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha); //atribuindo a variavel "usuarioAutenticado" o valor de retorno do método
                                                                     //"Autenticar" criado dentro da classe Diretor.
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
