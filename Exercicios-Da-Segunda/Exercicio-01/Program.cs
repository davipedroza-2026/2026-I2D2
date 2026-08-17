using System.Runtime.InteropServices;

internal class Program
{
    public class Cidades
    {
        public string? Nome { get; set; }
        //  Exercício 01 — Lista de Cidades

        //Crie uma `List<string>` contendo o nome de **5 cidades brasileiras**.

        //Utilize `foreach` para percorrer a lista e imprimir cada cidade no console.

        //Conceitos: `List<T>` • `foreach`
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("-------Lista de 5 cidades Brasileiras-------");

        List<Cidades> listaCidades = new List<Cidades>();

        Cidades cidade1 = new Cidades
        {
            Nome = "Salvador"
        };
        Cidades cidade2 = new Cidades
        {
            Nome = "São-Paulo"
        };
        Cidades cidade3 = new Cidades
        {
            Nome = "Santos"
        };
        Cidades cidade4 = new Cidades
        {
            Nome = "Sorocaba"
        };
        Cidades cidade5 = new Cidades
        {
            Nome = "Suzano"
        };

        listaCidades.Add(cidade1);
        listaCidades.Add(cidade2);
        listaCidades.Add(cidade3);
        listaCidades.Add(cidade4);
        listaCidades.Add(cidade5);

        foreach (var item in listaCidades)
        {
            Console.WriteLine($"{item.Nome}");
        }

    }

}