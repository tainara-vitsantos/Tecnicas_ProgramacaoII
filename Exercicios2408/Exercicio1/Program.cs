using System;

var frutas = new string[] { "Maça", "Banana", "Laranja", "Uva", "Manga",
    "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };


// a. Exibir nomes e quantidade usando foreach
Console.WriteLine("Lista de frutas:");
foreach (var fruta in frutas)
{
    Console.WriteLine($" - {fruta}");
}
Console.WriteLine($"Quantidade: {frutas.Length} frutas\n");

// b. Segunda e penúltima fruta
Console.WriteLine($"b. Segunda fruta: {frutas[1]}");
Console.WriteLine($"   Penúltima fruta: {frutas[8]}\n");

// c. Alterar terceira e última
frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Console.WriteLine(" Lista após alterações:");
foreach (var fruta in frutas)
{
    Console.WriteLine($"  - {fruta}");
}
Console.WriteLine();

// d. Ordenar e exibir inverso
Array.Sort(frutas);
Console.WriteLine(" Frutas em ordem inversa:");
for (int i = frutas.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"  - {frutas[i]}");
}

