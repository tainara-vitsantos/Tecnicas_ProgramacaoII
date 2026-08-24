using System;
using System.Collections.Generic;


// Classe base Bebida
public abstract class Bebida
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    public Bebida(int id, string nome, decimal precoBase)
    {
        Id = id;
        Nome = nome;
        PrecoBase = precoBase;
    }

    public abstract decimal CalcularPreco();

    public virtual void Exibir()
    {
        Console.WriteLine($"ID: {Id}, Nome: {Nome}, Preço Base: R$ {PrecoBase:F2}");
    }
}

// Classe CafeExpresso
public class CafeExpresso : Bebida
{
    public int QtdShots { get; set; }
    public decimal PrecoPorShot { get; set; }

    public CafeExpresso(int id, string nome, decimal precoBase, int qtdShots, decimal precoPorShot)
        : base(id, nome, precoBase)
    {
        QtdShots = qtdShots;
        PrecoPorShot = precoPorShot;
    }

    public override decimal CalcularPreco()
    {
        return PrecoBase + (QtdShots * PrecoPorShot);
    }

    public override void Exibir()
    {
        Console.WriteLine($"Café Expresso - ID: {Id}, Nome: {Nome}, Preço Base: R$ {PrecoBase:F2}, Shots: {QtdShots}, Preço por Shot: R$ {PrecoPorShot:F2}, Total: R$ {CalcularPreco():F2}");
    }
}


// Classe Frappuccino

public class Frappuccino : Bebida
{
    public string SaborCalda { get; set; }
    public bool TemChantilly { get; set; }

    public Frappuccino(int id, string nome, decimal precoBase, string saborCalda, bool temChantilly)
        : base(id, nome, precoBase)
    {
        SaborCalda = saborCalda;
        TemChantilly = temChantilly;
    }

    public override decimal CalcularPreco()
    {
        decimal preco = PrecoBase;
        if (TemChantilly)
        {
            preco += 2.00m; // Adiciona R$ 2,00 pelo chantilly
        }
        return preco;
    }

    public override void Exibir()
    {
        string chantilly = TemChantilly ? "Sim" : "Não";
        Console.WriteLine($"Frappuccino - ID: {Id}, Nome: {Nome}, Preço Base: R$ {PrecoBase:F2}, Sabor: {SaborCalda}, Chantilly: {chantilly}, Total: R$ {CalcularPreco():F2}");
    }
}


// Classe Barista Associação

public class Barista
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string NivelExperiencia { get; set; }

    public Barista(int id, string nome, string nivelExperiencia)
    {
        Id = id;
        Nome = nome;
        NivelExperiencia = nivelExperiencia;
    }

    public void Exibir()
    {
        Console.WriteLine($"Barista ID: {Id}, Nome: {Nome}, Experiência: {NivelExperiencia}");
    }
}


// Classe ItemComanda composição/associação

public class ItemComanda
{
    public int Id { get; set; }
    public Bebida Bebida { get; set; }
    public int Quantidade { get; set; }

    public ItemComanda(int id, Bebida bebida, int quantidade)
    {
        Id = id;
        Bebida = bebida;
        Quantidade = quantidade;
    }

    public decimal CalcularSubtotal()
    {
        return Bebida.CalcularPreco() * Quantidade;
    }

    public void Exibir()
    {
        Console.WriteLine($"Item {Id} - {Bebida.Nome} x {Quantidade} = R$ {CalcularSubtotal():F2}");
    }
}


// Classe Comanda Composição/associação

public class Comanda
{
    public int Id { get; set; }
    public int Mesa { get; set; }
    public DateTime DataHora { get; set; }
    public Barista Barista { get; set; }
    public List<ItemComanda> Itens { get; set; }

    public Comanda(int id, int mesa, Barista barista)
    {
        Id = id;
        Mesa = mesa;
        DataHora = DateTime.Now;
        Barista = barista;
        Itens = new List<ItemComanda>();
    }

    public void AdicionarItem(Bebida bebida, int quantidade)
    {
        int novoId = Itens.Count + 1;
        ItemComanda item = new ItemComanda(novoId, bebida, quantidade);
        Itens.Add(item);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (ItemComanda item in Itens)
        {
            total += item.CalcularSubtotal();
        }
        return total;
    }

    public void Exibir()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine($"COMANDA #{Id}");
        Console.WriteLine($"Mesa: {Mesa}");
        Console.WriteLine($"Data/Hora: {DataHora}");
        Console.WriteLine($"Barista: {Barista.Nome} (Experiência: {Barista.NivelExperiencia})");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("ITENS CONSUMIDOS:");

        if (Itens.Count == 0)
        {
            Console.WriteLine("Nenhum item na comanda.");
        }
        else
        {
            foreach (ItemComanda item in Itens)
            {
                item.Exibir();
            }
        }

        Console.WriteLine($"TOTAL DA COMANDA: R$ {CalcularTotal():F2}");

    }
}

//Teste
class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE GERENCIAMENTO DE COMANDAS - CAFETERIA ===\n");

        // CRIANDO BEBIDAS
        Console.WriteLine("--- CRIANDO BEBIDAS ---\n");

        // Café Expresso
        CafeExpresso cafe1 = new CafeExpresso(1, "Café Expresso", 5.00m, 2, 1.50m);
        CafeExpresso cafe2 = new CafeExpresso(2, "Café Duplo", 7.00m, 3, 1.50m);

        // Frappuccino
        Frappuccino frapp1 = new Frappuccino(3, "Frappuccino Caramelo", 12.00m, "Caramelo", true);
        Frappuccino frapp2 = new Frappuccino(4, "Frappuccino Morango", 12.00m, "Morango", false);
        Frappuccino frapp3 = new Frappuccino(5, "Frappuccino Chocolate", 12.00m, "Chocolate", true);

        // Exibindo bebidas
        Console.WriteLine("Bebidas disponíveis:");
        cafe1.Exibir();
        cafe2.Exibir();
        frapp1.Exibir();
        frapp2.Exibir();
        frapp3.Exibir();

        Console.WriteLine("\n============================================\n");


        // CRIANDO BARISTAS
        Console.WriteLine("--- CRIANDO BARISTAS ---\n");

        Barista barista1 = new Barista(1, "Carlos Silva", "Avançado");
        Barista barista2 = new Barista(2, "Maria Santos", "Intermediário");

        barista1.Exibir();
        barista2.Exibir();

        Console.WriteLine("\n============================================\n");


        // CRIANDO COMANDAS COM ITENS
        Console.WriteLine("--- CRIANDO COMANDAS ---\n");

        // Comanda 1
        Comanda comanda1 = new Comanda(1, 5, barista1);
        comanda1.AdicionarItem(cafe1, 2);  // 2 Cafés Expresso
        comanda1.AdicionarItem(frapp1, 1); // 1 Frappuccino Caramelo
        comanda1.Exibir();

        // Comanda 2
        Comanda comanda2 = new Comanda(2, 8, barista2);
        comanda2.AdicionarItem(cafe2, 1);  // 1 Café Duplo
        comanda2.AdicionarItem(frapp2, 2); // 2 Frappuccino Morango
        comanda2.AdicionarItem(frapp3, 1); // 1 Frappuccino Chocolate
        comanda2.Exibir();

        // Comanda 3
        Comanda comanda3 = new Comanda(3, 12, barista1);
        comanda3.AdicionarItem(cafe1, 3);  // 3 Cafés Expresso
        comanda3.AdicionarItem(frapp3, 2); // 2 Frappuccino Chocolate
        comanda3.Exibir();

        Console.WriteLine("\n============================================\n");
        Console.WriteLine("\n--- RESUMO DAS COMANDAS ---\n");

        Console.WriteLine($"Total de comandas criadas: 3");
        Console.WriteLine($"Total de itens na Comanda #1: {comanda1.Itens.Count}");
        Console.WriteLine($"Total de itens na Comanda #2: {comanda2.Itens.Count}");
        Console.WriteLine($"Total de itens na Comanda #3: {comanda3.Itens.Count}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}