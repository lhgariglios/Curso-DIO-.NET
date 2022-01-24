using System; // Para usar classes do namespace system
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroducaoCsharp;
using Interface;
using Enum;

namespace IntroducaoCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoas person = new Pessoas(); // Objeto da classe pessoa.
			person.Nome = "Luiz";
			person.Estado = "MG";
			person.Idade = 18;

			var animal = new Animal();

			animal.Nome = "Billy";
			animal.NomeDono = "Luiz";
			animal.Especie = "Cachorro";

			var pessoa = (Colegas)0; //pessoa tem o valor de pessoa na posição zero

		}

	}
}


/*
	Namespace: 
		- Organiza classes;
		- Podem ter quantos se desejar;
		- Não pode existir duas classes de mesmo nome em um único namespace;
		- Nome do namespace Nome da Classe --> Outra forma de usar classes de outros namespaces;
	Interface:
		- Classe base que serve de molde para outras;
*/ 