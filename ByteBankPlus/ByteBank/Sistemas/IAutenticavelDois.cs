using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    //convenção utilizar sempre o "I" para identificar que é uma interface
    public interface IAutenticavelDois //utilizando a interface, para que assim eu
                                      //possa vincular um classe e uma interface dentro de uma classe
    {
        bool Autenticar(string senha);
    }
}
