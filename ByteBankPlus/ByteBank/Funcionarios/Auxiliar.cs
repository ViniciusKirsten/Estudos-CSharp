using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Auxiliar : Funcionario //Assim eu estou fazendo ele herdar as informações do "Funcionario"
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBronificacao()
        {
            return Salario * 0.2;
        }
    }
}
