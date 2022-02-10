using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientacao_Objeto
{
    public class Aluno : Pessoa // Aluno herda a classe Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar() // Sobrescreve
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, tenho {Idade} anos e minha nota e {Nota}.");
        }
    }

    public class Professor : Pessoa // Professor herda a classe Pessoa
    {
        public int Salario { get; set; }
        public override void Apresentar() // Sobrescreve
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, tenho {Idade} anos e sou professor. Ganho {Salario} reais.");
        }
    }
}
