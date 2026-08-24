using System;

class Program
{
    static void Main()
    {
        // a. Solicitar o número de valores do array
        Console.Write("Digite a quantidade de valores do array: ");
        int tamanho = int.Parse(Console.ReadLine()!); 

        // b. Declarar e inicializar o array
        int[] numeros = new int[tamanho];

        // Preencher o array
        Console.WriteLine($"\nDigite os {tamanho} números inteiros:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine()!); 
        }

        // Mostrar o array
        Console.WriteLine("\nArray preenchido:");
        foreach (int num in numeros)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("\n");

        // e. Repetir até que o texto 'fim' seja inserido
        string entrada;
        do
        {
            Console.Write("Digite um número para pesquisar (ou 'fim' para sair): ");
            entrada = Console.ReadLine()!; 

            if (entrada != "fim")
            {
                int numeroProcurar = int.Parse(entrada);

                bool encontrado = false;
                foreach (int num in numeros)
                {
                    if (num == numeroProcurar)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine($"O número {numeroProcurar} foi ENCONTRADO!\n");
                }
                else
                {
                    Console.WriteLine($"O número {numeroProcurar} NÃO foi encontrado!\n");
                }
            }

        } while (entrada != "fim");

        Console.WriteLine("\nPrograma finalizado!");
        Console.ReadKey();
    }
}