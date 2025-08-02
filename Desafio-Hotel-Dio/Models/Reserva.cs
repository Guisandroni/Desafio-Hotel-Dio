namespace Desafio_Hotel_Dio.Models;

public class Reserva
{
    private Suite suite;
    private List<Pessoa> _Hospedes;
    private int diasReservados;


    public Reserva( int diasReservados)
    {
   
        this.diasReservados = diasReservados;
    }

    public Suite Suite
    {
        get => suite;
        set => suite = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Pessoa> Hospedes
    {
        get => _Hospedes;
        set => _Hospedes = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int DiasReservados
    {
        get => diasReservados;
        set => diasReservados = value;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
        {
            throw new ArgumentException("Suite precisa ser cadastrada antes");

        }
        if (hospedes.Count() <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new ArgumentException("Quantidade de hospedes excede a suite");
        }
        
        // Hospedes.AddRange(hospedes);
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        if (Hospedes != null)
        {
            return  Hospedes.Count();
        }
        else
        {
            return 0;
        }
      
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = diasReservados * Suite.ValorDiaria;
        if (diasReservados >= 10)
        {
            valor *=   0.90m ;
           
        }

        return valor;



    }
}