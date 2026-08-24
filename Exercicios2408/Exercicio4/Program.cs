using System;
using System.Collections;

// Classe Pessoa
public class Pessoa
{
    // Propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir
    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

// Programa principal
class Program
{
    static void Main()
    { 
        // b. Criar ArrayList e solicitar dados de 3 pessoas
        ArrayList pessoas = new ArrayList();

        Console.WriteLine("Digite os dados das 3 primeiras pessoas:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nPessoa {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine()!);

            // Criar objeto Pessoa e adicionar na ArrayList
            Pessoa pessoa = new Pessoa(nome, idade);
            pessoas.Add(pessoa);
        }

        // c. Exibir lista de pessoas
        Console.WriteLine("\nLista ede pessoas: ");
        foreach (Pessoa p in pessoas)
        {
            p.Exibir();
        }

        // d. Incluir mais dois objetos Pessoa (Jaime,20 - Tânia,18)
        Console.WriteLine("\nAdicionando mais 2 pessoas: ");
        pessoas.Add(new Pessoa("Jaime", 20));
        pessoas.Add(new Pessoa("Tânia", 18));

        // Exibir nova lista
        Console.WriteLine("\nNova Lista:");
        foreach (Pessoa p in pessoas)
        {
            p.Exibir();
        }

        // e. Remover o último elemento da coleção
        Console.WriteLine("\nRemovendo o ultimo elemento");
        pessoas.RemoveAt(pessoas.Count - 1);

        // Exibir lista completa após remoção
        Console.WriteLine("\nLista após remoção: ");
        foreach (Pessoa p in pessoas)
        {
            p.Exibir();
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}