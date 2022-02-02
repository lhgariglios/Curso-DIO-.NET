using System;

namespace Aula_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Pedro";
            p1.Idade = 20;
            p1.Apresentar();
        }
    }
}