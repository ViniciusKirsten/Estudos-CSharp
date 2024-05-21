using _05_ByteBank; //adicionando o namespace aqui, para que eu não precise adicionar um cada chamada

namespace _05_ByteBank //sempre utilizar, assim o compilador consegue se resolver sem o using
{
    public class ContaCorrente
    {
        public _05_ByteBank.Cliente titular; //posso colocar o namespace aqui ou acima, importando com uma biblioteca
        public Cliente nome;//exemplo importando pelo "using"
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo = valor;
                return true;
            }

        }
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo = valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
