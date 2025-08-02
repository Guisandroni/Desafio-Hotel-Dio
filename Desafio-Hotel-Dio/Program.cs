// See https://aka.ms/new-console-template for more information


using Desafio_Hotel_Dio.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Joao","Silva");
Pessoa p2 = new Pessoa("Guilherme","Dias");

hospedes.Add(p1);

Suite suite = new Suite("Basica",4,40);

Reserva reserva = new Reserva(30);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);



Console.WriteLine($"Quantidade de hospedes: {reserva.ObterQuantidadeHospedes()}");

Console.WriteLine($"Valor da Diaria: {reserva.CalcularValorDiaria()}");

