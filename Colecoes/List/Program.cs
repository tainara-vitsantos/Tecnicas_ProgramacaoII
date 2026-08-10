// Performance do List é muito melhor que a do ArrayList

// Todas as operações utilizadas no ArrayList funcionam no List

// Criando uma lista de strings
List<string> nomes = new List<string>()
{
    "Joaquim",
    "Carlos",
    "Daniel",
    "Rafael"
};

// Métodos disponíveis no List
// Find(Predicado)
// FindLast()
// FindIndex()
// FindLastIndex()
// FindAll(Predicado)

// O que é um predicado?
// É uma função que retorna um valor booleano,
// ou seja, true ou false.

// Contains() - Verifica se o elemento existe na lista

// Find() procura o PRIMEIRO elemento que atende à condição
var ret = nomes.Find(Procurar);

if (ret != null)
{
    Console.WriteLine("Nome encontrado: " + ret);
}
else
{
    Console.WriteLine("Nome não encontrado");
}

// Método utilizado como predicado
// Verifica se o nome contém a letra 'a'
static bool Procurar(string nome)
{
    return nome.Contains('a');
}


// --------------------------------------------------
// EXPRESSÃO LAMBDA
// --------------------------------------------------

Console.WriteLine("Expressão lambda");

// A expressão lambda substitui o método Procurar()
// x representa cada elemento da lista
// => significa "vai para"
// Contains('a') verifica se o nome contém a letra 'a'

// Find() retorna apenas o PRIMEIRO resultado encontrado
var ret2 = nomes.Find(x => x.Contains('a'));

Console.WriteLine(ret2);


// --------------------------------------------------
// FINDALL
// --------------------------------------------------

Console.WriteLine("FindAll");

// FindAll() retorna TODOS os elementos
// que atendem à condição
var ret3 = nomes.FindAll(x => x.Contains('a'));

// foreach percorre todos os elementos encontrados
foreach (var nome in ret3)
{
    Console.WriteLine(nome);
}


// --------------------------------------------------
// FINDLAST
// --------------------------------------------------

Console.WriteLine("FindLast");

// FindLast() procura o ÚLTIMO elemento
// que atende à condição
var ret4 = nomes.FindLast(x => x.Contains('e'));

Console.WriteLine(ret4);


// --------------------------------------------------
// LISTA DE PRODUTOS
// --------------------------------------------------

// Criando uma lista que armazena objetos do tipo Produto
var produtos = new List<Produto>();

// Adicionando um novo produto à lista
produtos.Add(new Produto(1, "Notebook", 3500.00m));
produtos.Add(new Produto(2, "Mouse", 50.00m));
produtos.Add(new Produto(3, "Teclado", 150.00m));

foreach (var produto in produtos)
{
    Console.WriteLine($"Produto:{produto.Id} - {produto.Nome} - {produto.Preco}");
}


    // Aguarda uma tecla ser pressionada
    Console.ReadKey();


// --------------------------------------------------
// CLASSE PRODUTO
// --------------------------------------------------

// Definição da classe Produto
public class Produto
{
    // Construtor vazio
    public Produto()
    {
    }

    // Construtor que recebe os dados do produto
    public Produto(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }

    // Propriedade que armazena o ID do produto
    public int Id { get; set; }

    // Propriedade que armazena o nome do produto
    public string Nome { get; set; }

    // Propriedade que armazena o preço do produto
    // decimal é utilizado para valores monetários
    public decimal Preco { get; set; }
}