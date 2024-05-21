using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }

        //Obrigatório adicionar o método que colocamos como abstratos na classe mãe
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }
    }
}
