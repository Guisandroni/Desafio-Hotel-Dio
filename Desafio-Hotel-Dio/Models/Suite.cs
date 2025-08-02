namespace Desafio_Hotel_Dio.Models;

public class Suite
{
    private string tipoSuite;
    private int capacidade;
    private decimal valorDiaria;

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        this.tipoSuite = tipoSuite;
        this.capacidade = capacidade;
        this.valorDiaria = valorDiaria;
    }

    public string TipoSuite
    {
        get => tipoSuite;
        set => tipoSuite = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Capacidade
    {
        get => capacidade;
        set => capacidade = value;
    }

    public decimal ValorDiaria
    {
        get => valorDiaria;
        set => valorDiaria = value;
    }
}