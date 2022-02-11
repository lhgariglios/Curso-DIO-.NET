using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Construtores.Modelos
{
    internal class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome; //variáveis readonly só podem ser alteradas na inicialização ou nos construtores.
        public Pessoa() //Construtor; Mesmo nome da classe e não tem retorno
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá!Me chamo {nome} {sobrenome}.");
        }
    }
}
