﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBronificacao()
        {
            return Salario * 0.25;
        }
    }
}
