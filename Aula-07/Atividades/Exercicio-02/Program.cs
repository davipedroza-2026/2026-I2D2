internal class Program
{
    private static void Main(string[] args)
    {
       // crie uma classe `Aluno` com as propriedades:

    //Nome`
    //Idade`

 // Cadastre 5 alunos utilizando uma `List<Aluno>`.

// O programa deve:

 //Exibir todos os alunos.
//Permitir alterar a idade de um aluno.
//Permitir remover um aluno pelo nome.
//Exibir a lista final.

//Conceitos:** `List<T>`, objetos, pesquisa, alteração e remoção.

    // Primeiro aluno
        Aluno aluno1 = new List<Aluno>();
        aluno1.Nome = "Marcos";
        aluno1.Nascimento = new DateOnly(2018, 5, 15); // ano,mes,dia

        // Segundo aluno
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Junior";
        aluno2.Nascimento = new DateOnly(2007, 9, 2);

        // Terceiro aluno
        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Caio";
        aluno3.Nascimento = new DateOnly(2010, 7, 10);

        //  Quarto aluno 
        Aluno aluno4 = new Aluno();
        aluno4.Nome = "Eduardo";
        aluno4.Nascimento = new DateOnly(2006, 4, 20);

        //  Quinto aluno 
        Aluno aluno5 = new Aluno();
        aluno5.Nome = "Carlos";
        aluno5.Nascimento = new DateOnly(2009, 2, 16);

        //  Sexto aluno 
        Aluno aluno6 = new Aluno();
        aluno6.Nome = "Eduardo";
        aluno6.Nascimento = new DateOnly(2011, 3, 15);


        // Exibindo os alunos
        Console.WriteLine("=== ALUNOS ===");

        Console.WriteLine("\nAluno 1");
        Console.WriteLine($"Nome: {aluno1.Nome}");
        Console.WriteLine($"Nascimento: {aluno1.Nascimento:dd/MM/yyyy}");

        Console.WriteLine("\nAluno 2");
        Console.WriteLine($"Nome: {aluno2.Nome}");
        Console.WriteLine($"Nascimento: {aluno2.Nascimento:dd/MM/yyyy}");

        Console.WriteLine("\nAluno 3");
        Console.WriteLine($"Nome: {aluno3.Nome}");
        Console.WriteLine($"Nascimento: {aluno3.Nascimento:dd/MM/yyyy}");

        Console.WriteLine("\nAluno 4");
        Console.WriteLine($"Nome: {aluno4.Nome}");
        Console.WriteLine($"Nascimento: {aluno4.Nascimento:dd/MM/yyyy}");

        Console.WriteLine("\nAluno 5");
        Console.WriteLine($"Nome: {aluno5.Nome}");
        Console.WriteLine($"Nascimento: {aluno5.Nascimento:dd/MM/yyyy}");


    }
    public class Aluno
    {
        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }




    }

    }
}