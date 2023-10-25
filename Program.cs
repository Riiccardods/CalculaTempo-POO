namespace pooCalculaIdade
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma Pessoa");


            Console.WriteLine("nome da pessoa");
            string nome = Console.ReadLine();

            Console.WriteLine("Ano de nascimento");
            int  ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome,ano);
           
            p.ExibirDados();



        }



    }
}
