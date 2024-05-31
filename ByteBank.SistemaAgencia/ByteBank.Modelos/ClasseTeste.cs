using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        { 
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();//consigo trazer até aqui, pois ele é um método publico

            teste.MetodoInterno(); //visivel para o projeto ByteBank.Modelos

            //teste.MetodoProtegido(); //não consigo pois ele é protegido

            //teste.MetodoPrivado(); //não consigo pois ele é privado
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido(); //Consigo acessar o método mesmo sendo protegido, pois ele é derivado daquela classe
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            //Visivel apenas na classe "ModificadoresTeste" e derivados
        }
        private void MetodoPrivado()
        {
            //Visivel apenas na classe "ModificadoresTeste"
        }

        internal void MetodoInterno()
        {

        }

        internal protected void MetodoInternoProtegido()
        {
            //Visivel para membros dentros do pacote e classes que derivam 

            //ele faz sentido apenas nas classes bases
        }
    }
}

