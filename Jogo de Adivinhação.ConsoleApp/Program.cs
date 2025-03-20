namespace Jogo_de_Adivinhação.ConsoleApp
{
    internal class Program
    {
        //Versao 1 : Estrutura Básica e entrada do usuario
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("-------------------------");

            // logica do jogo
            Console.WriteLine("dIgite um número:");
            int numerodigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você digitou o número " + numerodigitado);

            Console.ReadLine(); 

        }
    }
}
