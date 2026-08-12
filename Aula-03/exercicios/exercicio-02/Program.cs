using System.Diagnostics;

internal partial class Program
{
    private static void Main(string[] args)
    {
        /*
- Switch;
- Métodos;
- Retorno de valores;
- Operações matemáticas.
        
        Requisitos
1. Solicitar dois números;
2. Apresentar um menu de operações;
3. Executar a operação escolhida;
4. Exibir o resultado.

    exemplo
Número 1: 10
Número 2: 5
Operação: 1

Saída:

Resultado: 15
 */
   double num1;
        double num2;
        double math;

     Console.WriteLine ("Numero 1: ");
     num1 = double.Parse(Console.ReadLine());
     Console.WriteLine (" Numero 2: ");
     num2 = double.Parse(Console.ReadLine());

     /*-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-*/
     Console.WriteLine("1 * Soma");
     Console.WriteLine("2 * Subtração");
     Console.WriteLine("3 * Multiplicacão");
     Console.WriteLine("4 * Divisão");
     /*-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-*/
     
     Console.Write("Escolha as Opções: ");
     int opcao = int.Parse(Console.ReadLine());

     switch (opcao)
    {
    case 1:
        Math = num1 + num2;
        Console.WriteLine($"A Soma do " {num1} e {num2} igual a {Math});
        break;
     case 2:
        Math = num1 - num2; 
        Console.WriteLine($"A  subtração do " {num1} e {num2} igual a {Math});
        break;                                                                                                                                                                                                                                                                       ")  
    } case 3:
        Math = num1 * num2; 
        Console.WriteLine($"A    multiplicação do " {num1} e {num2} igual a {Math});
        break;                                 
    case 4:
        Math = num1 / num2; 
        Console.WriteLine($"A  Divisão do " {num1} e {num2} igual a {Math});
        break; 
    default
        Console.WriteLine(" Opção incorreta!");
        break;                                

  
    }
}

