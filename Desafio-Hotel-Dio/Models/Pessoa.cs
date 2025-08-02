namespace Desafio_Hotel_Dio.Models;

public class Pessoa
{
    private string nome;
    private string sobrenome;

    public Pessoa(string nome, string sobrenome)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
    }

    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Sobrenome
    {
        get => sobrenome;
        set => sobrenome = value ?? throw new ArgumentNullException(nameof(value));
    }
}