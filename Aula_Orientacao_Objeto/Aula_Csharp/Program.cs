using System;

namespace Aula_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstração & Herança & Polimorfismo tempo de execução
            Aluno a1 = new Aluno();
            a1.Nome = "Maria";
            a1.Idade = 17; 
            a1.Nota = 10;
            a1.Apresentar();
            Professor p1 = new Professor();
            p1.Nome = "Pedro";
            p1.Idade = 25;
            p1.Salario = 3000;
            p1.Apresentar();

            //Encapsulamento
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);
            System.Console.WriteLine($"Area: {r.ObterArea()}");

            //Polimorfismo tempo de compilação
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Soma(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Soma(10, 10, 10));

        }
    }
}