using System;
using System.Collections;


// Classe produto
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"ID: {Id}, Nome: {Nome}, Preço: R$ {Preco:F2}");
    }
}


class Program
{
    static void Main()
    {
        // Criar ArrayList para armazenar produtos
        ArrayList produtos = new ArrayList();
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Remover produto");
            Console.WriteLine("3 - Exibir lista de produtos");
            Console.WriteLine("4 - Sair");
            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine()!);

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    // Adicionar produto
                    Console.WriteLine("--- ADICIONAR PRODUTO ---");
                    
                    Console.Write("Digite o ID do produto: ");
                    int id = int.Parse(Console.ReadLine()!);
                    
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine()!;
                    
                    Console.Write("Digite o preço do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine()!);

                    Produto novoProduto = new Produto(id, nome, preco);
                    produtos.Add(novoProduto);
                    
                    Console.WriteLine($"\nProduto '{nome}' adicionado com sucesso!");
                    break;

                case 2:
                    // Remover produto
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia!");
                    }
                    else
                    {
                        Console.WriteLine("--- REMOVER PRODUTO ---");
                        Console.Write("Digite o ID do produto a ser removido: ");
                        int idRemover = int.Parse(Console.ReadLine()!);

                        bool encontrado = false;
                        foreach (Produto p in produtos)
                        {
                            if (p.Id == idRemover)
                            {
                                produtos.Remove(p);
                                Console.WriteLine($"\nProduto ID {idRemover} removido com sucesso!");
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine($"\nProduto com ID {idRemover} não encontrado!");
                        }
                    }
                    break;

                case 3:
                    // Exibir lista de produtos
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia!");
                    }
                    else
                    {
                        Console.WriteLine("=== LISTA DE PRODUTOS ===");
                        Console.WriteLine($"Total de produtos: {produtos.Count}\n");
                        
                        int i = 1;
                        foreach (Produto p in produtos)
                        {
                            Console.Write($"{i}. ");
                            p.Exibir();
                            i++;
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 4);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}