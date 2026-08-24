using System;
using System.Collections.Generic;

// Classe Veiculo
public class Veiculo
{
    public string Marca { get; set; }

    public Veiculo(string marca)
    {
        Marca = marca;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca do veículo: {Marca}");
    }
}

// Classe Carro
public class Carro : Veiculo
{
    public int NumeroPortas { get; set; }

    public Carro(string marca, int numeroPortas) : base(marca)
    {
        NumeroPortas = numeroPortas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Carro - Marca: {Marca}, Número de Portas: {NumeroPortas}");
    }
}

//Classe Moto
public class Moto : Veiculo
{
    public bool PartidaEletrica { get; set; }

    public Moto(string marca, bool partidaEletrica) : base(marca)
    {
        PartidaEletrica = partidaEletrica;
    }

    public override void ExibirInformacoes()
    {
        string partida = PartidaEletrica ? "Sim" : "Não";
        Console.WriteLine($"Moto - Marca: {Marca}, Partida Elétrica: {partida}");
    }
}

//Programa para testes
class Program
{
    static void Main()
    {
        Console.WriteLine("\nTestando as classes: ");

        // Criando objetos
        Carro carro1 = new Carro("Fiat", 4);
        Carro carro2 = new Carro("Volkswagen", 2);
        Moto moto1 = new Moto("Honda", true);
        Moto moto2 = new Moto("Yamaha", false);

        // Exibindo informações
        Console.WriteLine("Informações dos Veículos:");
        carro1.ExibirInformacoes();
        carro2.ExibirInformacoes();
        moto1.ExibirInformacoes();
        moto2.ExibirInformacoes();

    }
}