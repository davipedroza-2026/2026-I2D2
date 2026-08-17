internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----------Dicionário--de--Produtos--de--Mercado------------");

        // Exercício 03 — Dictionary de Produtos

// Crie um `Dictionary<int, string>` representando um **cardápio de lanchonete**.

// - A chave deve representar o **código do produto**;
// - O valor deve representar o **nome do produto**;
// - Cadastre pelo menos **4 produtos**.

// Utilize `foreach` para imprimir os produtos no seguinte formato:

// Código - Nome

    Dictionary<int, string> Dicionario = new Dictionary<int, string>();

    Dicionario.Add(1, "x-Salada");
    Dicionario.Add(2,"x-Egg");
    Dicionario.Add(3, "X-tudo");
    Dicionario.Add(4, "x-Bacon");
//========================================================================================//;
    Console.WriteLine();
    foreach (var item in Dicionario )
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
//========================================================================================//;   

    }

}