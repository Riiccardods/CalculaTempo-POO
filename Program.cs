namespace pooCalculaIdade
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma Pessoa");
            Pessoa p = new Pessoa();
            Console.WriteLine("nome da pessoa");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Ano de nascimento");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p.ExibirDados();


        }



    }
}
