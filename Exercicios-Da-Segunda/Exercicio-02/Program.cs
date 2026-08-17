
internal class Program
{
    public class Numeros
    {
        public int num {get; set;}
    }
    
    // Exercício 02 — Manipulação de List

    //   Crie uma `List<int>` com os valores:

     // { 10, 25, 8, 42, 15, 30 }

    // Realize as seguintes operações:

    // 1. Insira o número `100` na posição `2`;
    // 2. Remova o elemento que está na última posição;
    // 3. Imprima a lista final.

    // Conceitos: `List<T>` • `Insert()` • `RemoveAt()` • `Count`


    private static void Main(string[] args) 
    {
        Console.WriteLine("-------Lista--de--Numeros-------{ 10, 25, 8, 42, 15, 30 }-------");

        List<int> Numeros = new List<int>{ 10, 25, 8, 42, 15, 30 };

        foreach (var item in Numeros)
        {
            Console.WriteLine($"{item}");
        };
    
        Numeros[2] = 100;
        

        Numeros.RemoveAt(5);
        Console.WriteLine();
        foreach (var item in Numeros)
        {
            Console.WriteLine($"{item}");
        }

    }
}