using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBronificacao();
        }
        /*
         * Falamos que temos uma "Sobrecarga" do metodo registrar,
         * pois existe dois metodos com o mesmo nome, porém com
         * atribuições diferentes.
        
        public void Registrar(Diretor funcionario)
        {
            _totalBonificacao += funcionario.GetBronificacao();
        }
        */
        
        public double GetTotalBonificado()
        {
            return _totalBonificacao;
        }
    }
}
