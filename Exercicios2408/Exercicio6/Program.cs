
// LISTA DE ALUNOS COM MENU
Console.WriteLine("Lista de Alunos: \n");

List<string> alunos = new List<string>();
int opcao;

do
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Adicionar nome");
    Console.WriteLine("2 - Remover nome");
    Console.WriteLine("3 - Listar todos os nomes");
    Console.WriteLine("4 - Sair");
    Console.Write("\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine()!;
            alunos.Add(nome);
            Console.WriteLine($"Aluno '{nome}' adicionado com sucesso!");
            break;

        case 2:
            if (alunos.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
            }
            else
            {
                Console.Write("Digite o nome do aluno a ser removido: ");
                string nomeRemover = Console.ReadLine()!;

                if (alunos.Remove(nomeRemover))
                {
                    Console.WriteLine($"Aluno '{nomeRemover}' removido com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Aluno '{nomeRemover}' não encontrado na lista!");
                }
            }
            break;

        case 3:
            if (alunos.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
            }
            else
            {
                Console.WriteLine("=== LISTA DE ALUNOS ===");
                for (int i = 0; i < alunos.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {alunos[i]}");
                }
                Console.WriteLine($"Total de alunos: {alunos.Count}");
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
