using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    //Assim eu consigo deixar ela apenas como interna (internal)
    //Utilizando o exemplo, eu não consigo acessar ela utilizando o control + ponto, para visualizar a classe, pois a mesma
    //está interna para a biblioteca, assim é possivel somente visualizar dentro da classe ou biblioteca que ela está
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }

    }
}
