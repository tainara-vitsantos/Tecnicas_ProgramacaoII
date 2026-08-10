using System.Collections.Immutable;

int[] numeros = new int[] { 1, 2, 3 }; 

var nomes = new string[] { "Maria", "José" };

foreach(var nome in nomes)
{
    Console.WriteLine($"Nome = {nome}"); // Interpolação
    Console.WriteLine(nome); // pode ser assim 
}


foreach (var number in numeros)
{
    Console.WriteLine($"Número = {number}"); // Interpolação
}

int[,] numeros2 = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

for  (int i = 0; i < numeros2.GetLength(0); i++)
{
    for (int j = 0; j < numeros2.GetLength(1); j++)
    {
        Console.WriteLine($"Número = {numeros2[i, j]}");
    }
}

Console.WriteLine("Usando foreach com array multidimensional");

foreach (var number2 in numeros2)
{
    Console.WriteLine($"Número = {number2}"); // Interpolação
}
