using System.ComponentModel.Design;

public class ContaCorrente
{
    
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //bool = tipo de retorno
    //sacar = nome da funcao
    //valor = dado de entrada
    public bool Sacar(double valor) //Funcao sempre com a primeira letra maiuscula
    {
        if (this.saldo < valor) //this -> estou acesso o saldo desse objeto
        { 
            return false;
        }
        else
        {
            this.saldo = valor;
            return true;
        }
        
    }
    public void Depositar(double valor) //Método sem retorno e ou vazio
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false; //Quando temos um retorno, ele não executa o restante do código.
        }
        
        this.saldo = valor;
        contaDestino.Depositar(valor);
        return true;
        
    }

    /*
     * OBS: 
     * Quando retorno algum valor, chamamos de função.
     * Quando não retorna nenhum valor, chamamos de método.
     * 
     * ambos são corretos, porém a forma usual é como demostrado acima.
    */
}