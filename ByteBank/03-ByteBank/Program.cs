using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * No C# existe dois tipos de tipos (valor e referencia)
            */

            //Quando criamos uma instancia como esse objeto abaixo
            //"contaDaGabriela" é uma variavel de referencia, onde guarda o local que está armazenado esses dados
            ContaCorrente contaDaGabriela = new ContaCorrente(); //Quando utilizamos o "new" estyamos cirando na memória do 
                                                                 //comoputador, esse objeto.

            //essas "variaveis" são de fato variavies e sim referencias de onde ficou armazenado
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;
            contaDaGabrielaCosta.saldo = 100;

            //igualdade do tipo de referencia
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);
            /*
             * Resposta vai dar "False", por conta que são duas referencias
             * diferentes, os objetos estão guardando a referencia onde estão
             * armazenados, assim resultando na desigualdade.
             */

            int num = 1, num2 = 1;
            //igualdade do tipo de valor
            Console.WriteLine(num ==num2);
        }
    }
}