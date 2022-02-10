using System;

namespace Aula_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstração & Herança
            Aluno a1 = new Aluno();
            a1.Nome = "Maria";
            a1.Idade = 17;
            a1.Nota = 10;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Nome = "Pedro";
            p1.Idade = 25;
            p1.Salario = 1100;
            p1.Apresentar();

            //Encapsulamento
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");

        }
    }
}