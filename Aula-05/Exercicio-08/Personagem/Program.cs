internal class Program
{
    private static void Main(string[] args)
    {
    }

    public class Personagem
    {
        public String Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }
        public class Mago : Personagem;
        public class Elfo : Personagem;
        public class Cavaleiro : Personagem;

    }
    public void atacar(double 10)
    {

    }

}