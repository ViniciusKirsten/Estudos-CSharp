using ByteBank.Funcionarios; //precisava adicionar por conta dos diretórios
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
                /* Tentando chamar um método não estatico (CalcularBonificacao) para um metodo estático (Main).
                 * Ou seja o método estático não pertence a um objeto mas pertence a classe classe.
                 */

            /*
             * --Outra solução para o método estático.
             * 
             * Program programa = new Program();
             * programa.CalcularBonificacao();
             * 
             * --Porém, isso não é correto, pois não serioa uma soçução elegante.
             */
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(2000, "159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao() //Deixando o método estático eu consigo chamar ele na minha classe "Main"
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39"); //Mesmo a classe funcionario sendo abstrata, ainda podemos 
                                                                //ter os conceitos do polimorfismo, como nesse exemplo onde
                                                                //estamos utilizando o "Funcionario", porém instanciando de
                                                                //"Designer".

            Diretor roberta = new Diretor(2000,"159.753.398-04"); //este está diferente para manter o exemplo.
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês:" + gerenciadorBonificacao.GetTotalBonificado());
        }
    }
}