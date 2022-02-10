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

            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");
        }
    }
}