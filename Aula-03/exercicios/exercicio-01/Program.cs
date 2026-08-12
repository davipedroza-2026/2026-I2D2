internal class Program
{
    private static void Main(string[] args)
    {
      /* A formula utiliza é Fahrenheit =(Celsius * 9 / 5) + 32
      # Requisitos
      
      O programa deve:

1. Solicitar uma temperatura em Celsius;
2. Realizar a conversão;
3. Exibir o resultado em Fahrenheit.
      */   

    int celsius;
    Console.Write("Digite a temperatura em graus Celsius: ");
    celsius = int.Parse(Console.ReadLine());

    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine("A temperatura em Farhrenheit é: " + fahrenheit);



    }
}