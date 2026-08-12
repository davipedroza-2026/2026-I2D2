internal class Program
{
    private static void Main(string[] args)
    {
        /* Vetores e Matrizes
            Vetor => é uma estrututa de dados utilizada para armazenar varios valores de um mesmo tipo dentro de uma unica variavel 

            sitaxe: tipo [] nome_Vetor = new tipo[tamanho];
        */

        /* Iniciar um vetor -> lista de frutas */
        
        string[] listaFrutas = {"Maça","Manga", "Morango", "Melancia", "Malão"};

        Console.WriteLine("Acessar o terceiro elelmento da lista: ");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("A o segundo elemento da lista: ");
        listaFrutas[1] = "Banana";

        for (int indice =0; indice < listaFrutas.Count(); indice++ )
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        /* ************************************************************** */
        foreach(string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }
    }
}