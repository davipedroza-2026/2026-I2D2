internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Classe -> é a abstração de um objeto do mu do real para o mundo computacional.
            Objeto -> É a instancia de uma classe.
        */

        // Instanciar um objeto do Tipo Aluno
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        aluno01.Nome = "José da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = DateOnly(2010,01,15);

        aluno02.Nome = "João dos Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

    //Executar os Metodos
    aluno01.ApresetarSe();
    aluno02.ApresetarSe();


    }

    public class Aluno // Declaração de uma classe
    {
        //Atributos -> Caracteristicas

        public static Nome {get; set;}

        public int RM {get; set;}

        public DateOnly DataNascimento {get;set;}

        // Metodos -> Ações ou Funcionalidades
        public void  ApresetarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} Meu RM é {RM} nasci na data{DataNascimento}");
        }
    }
}