// Criando algumas variáveis

int idade = 35;
var idade2 = idade;

double altura = 1.75; // Não é obrigatório usar o D
float peso = 75.6f; //Tem que usar o F no final
decimal preco = 5.90m; //Tem que colocar o M obrigatório

string nome = "Maria";
string nome2 = "João";
string nome3 = "Maria";

//Mostrar no console com concatenação
Console.WriteLine("Idade: " + idade);

//Mostrar no console com interpolação
Console.WriteLine($"Idade: {idade2}");

idade = 40;
Console.WriteLine($"Idade1:{idade} - Idade2: {idade2}");

Console.WriteLine($"Nome: {nome} -Nome2: {nome2} - Nome3: {nome3}");

nome = "Pedro";


//Conversão de Tipo
double peso2 = peso;


Console.WriteLine("Digite a sua idade: ");
int idade3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a sua altura: ");
double altura2 = double.Parse(Console.ReadLine());
