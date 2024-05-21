namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private double _saldo = 100;
        private int _agencia;
        //GET E SET

        // get e set com as referencias criadas de forma subentendida
        public int Agencia { get; set; }
        public int Numero { get; set; }

        //criando um membro estático
        public static int TotalDeContasCriadas { get; private set; }//assim adicionamos uma privação apenas para a modificação
        //static informa que ele é apenas um membro dessa classe

        //Criando um metodo/funcao, assim não entra nenhum valor, apenas retorna
        public static int ObterTotalDeContasCriadas()
        {
            return TotalDeContasCriadas;
        }

         
        //get e set, utilizando uma referencia que criamos como privasa
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        public Cliente Titular02 { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set { 
                
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        //CONSTRUTORES
        /*
         * Os construtores podem serem utilizados, para que assim
         * obrigamos uitilizar todas referencia que vamos definir obrigatória 
         * dentro do objeto que estamos criando em uma nova classe.
         */
        public ContaCorrente(int agencia, int numero)
        {
         //referencia //valor na criação do objeto   
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }
        /*
         * Nesse exemplo acima, quando criarmos um objeto "ContaCorrente", 
         * sera necessário sempre informar "agencia" e "numero" em sua
         * criação.
         */
        
        //MEMBRO ESTÁTICO
        /*
         * Esse membro estático serve para informar que
         * essa referencia é particular da minha classe, assim eu não
         */

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo = valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo = valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}