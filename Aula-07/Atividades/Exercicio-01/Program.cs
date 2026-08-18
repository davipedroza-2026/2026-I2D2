internal class Program
{
    public class Frutas
    {
        // Crie um  aplicativo console que utiliza uma list<string> para armazenar nomes de frutas. 

        // O programa deve:

        //Adicionar inicialmente 5 frutas.
        //Exibir todas as frutas cadastradas.
        // Solicitar ao usuário uma nova fruta.
        //Adicionar a nova fruta à lista.
        //Exibir novamente a lista atualizada.

        //Conceitos:** `List`, `Add`, `foreach`.

        public string? Nome { get; set; }

    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS (Frutas)===");

        // 1 - Iniciar um nova lista
        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas Fruta1 = new Frutas
        {
            Nome = "banana"
        };
        Frutas Fruta2 = new Frutas
        {
            Nome = "Morango"
        };
        Frutas Fruta3 = new Frutas
        {
            Nome = "Uva"
        };
        Frutas fruta4 = new Frutas
        {
            Nome = "Goiaba"
        };
        Frutas fruta5 = new Frutas
        {
            Nome = "Laranja"
        };
        listaFrutas.Add(Fruta1);
        listaFrutas.Add(Fruta2);
        listaFrutas.Add(Fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Nome}");
        }
        Console.WriteLine("Adicionar alguma nova Fruta?");
        Frutas fruta6 = new Frutas { Nome = Console.ReadLine() };
        listaFrutas.Add(fruta6);

        Console.WriteLine();
        foreach (var Fruta in listaFrutas)
        {
            Console.WriteLine(Fruta.Nome);
        }


    }
}