using System;

class Program
{
    static void Main()
    { 
        float[,] notas = new float[2, 5];

        // Preencher Grupo 1
        Console.WriteLine("Digite as notas do GRUPO 1 (5 alunos):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            notas[0, i] = float.Parse(Console.ReadLine()!);
        }

        Console.WriteLine();

        // Preencher Grupo 2
        Console.WriteLine("Digite as notas do GRUPO 2 (5 alunos):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            notas[1, i] = float.Parse(Console.ReadLine()!);
        }

        Console.WriteLine();

        // Mostrar as notas do Grupo 1
        Console.WriteLine("Notas do GRUPO 1:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{notas[0, i]:F1} ");
        }
        Console.WriteLine();

        // Mostrar as notas do Grupo 2
        Console.WriteLine("Notas do GRUPO 2:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{notas[1, i]:F1} ");
        }
        Console.WriteLine("\n");

        // Calcular médias
        float somaGrupo1 = 0;
        float somaGrupo2 = 0;

        for (int i = 0; i < 5; i++)
        {
            somaGrupo1 += notas[0, i];
            somaGrupo2 += notas[1, i];
        }

        float mediaGrupo1 = somaGrupo1 / 5;
        float mediaGrupo2 = somaGrupo2 / 5;

        // Exibir resultados
        Console.WriteLine("=== RESULTADOS ===\n");
        Console.WriteLine($"Média do GRUPO 1: {mediaGrupo1:F2}");
        Console.WriteLine($"Média do GRUPO 2: {mediaGrupo2:F2}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}