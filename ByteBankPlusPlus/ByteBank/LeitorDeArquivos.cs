using System;
using System.IO;

public class LeitorDeArquivo : IDisposable
{
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
        Arquivo = arquivo;
        throw new FileNotFoundException(); //Exceção para dizer que o arquivo não existe
        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }

    public string LerProximaLinha()
    {
        Console.WriteLine("Lendo linha...");

        throw new IOException(); //essa é uma exceção definida pelo .NET, ela fica definida como uma exceção de entrada ou saida (IN ou OUT = I0)
    }

    //Tivemos que criar esse método pois existia na classe "IDisposible", assim sendo necessário para utilizar o importador
    public void Dispose()
    { //assim ele fecha o arquivo, por intemédio da própria interface
        Console.WriteLine("Fechando arquivo.");

    }
}