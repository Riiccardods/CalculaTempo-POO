using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Pessoa
    {


		private int anoNascimento;

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}


		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		//Vamos melhorar

		private int idade;

		public int Idade
		{
			get { 
				this.CalcularIdade();
				return this.idade; }
		}



		public void ExibirDados() 
		{
			Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade() 
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			this.idade = ano - this.anoNascimento;
		}



	}
}
