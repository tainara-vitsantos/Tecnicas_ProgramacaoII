using System.Collections;

var mercado = new ArrayList() { "Paulo", 17, 1.75, true };

Console.WriteLine("Lista original");

listar(mercado);

Console.WriteLine("ArrayList usando Add");
mercado.Add("Maria"); // Vai no ultimo indice

listar(mercado);


Console.WriteLine("ArrayList usando Insert");
mercado.Insert(1, false); // Primeiro argumento é o indice e o segundo é o valor a ser inserido
listar(mercado);

Console.WriteLine("ArrayList usando AddRange");
int[] vet = new int[] { 10, 20, 30 };
mercado.AddRange(vet); 
listar(mercado);

Console.WriteLine("ArrayList usando InsertRange");
mercado.InsertRange(2, vet);
listar(mercado);


Console.WriteLine("ArrayList usando Remove");
mercado.Remove(17); // Remove o primeiro elemento que for igual ao valor passado como parametro
listar(mercado);

Console.WriteLine("ArrayList usando RemoveAt");
mercado.RemoveAt(0); // O parametro é o indice do elemento a ser removido
listar(mercado);


Console.WriteLine("ArrayList usando RemoveRange");
mercado.RemoveRange(7, 3); // Primeiro paramentro é o indice inicial e o segundo é a quantidade de elementos a serem removidos
listar(mercado);


var nomes = new ArrayList() {"Zenaide", "Maria", "José", "João" }; // devem ser do mesmo tipo, senao nao consegue ordenar
Console.WriteLine("ArrayList Ordenado");
nomes.Sort(); // Ordena os elementos do ArrayList
listar(nomes);


static void listar(ArrayList mercado)
{
    foreach (var item in mercado)
    {
        Console.WriteLine($"Item = {item}");
    }
}

