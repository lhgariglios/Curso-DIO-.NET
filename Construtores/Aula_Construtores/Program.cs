using System;
using Aula_Construtores.Modelos;

namespace Aula_Construtores
{
    class Program
    {
        public delegate void Operacao(int x, int y); // declara o delegate.
        static void Main(string[] args)
        {
            // Construtor
            Pessoa p1 = new Pessoa("Victor","Reis");
            p1.Apresentar();

            //Construtor privado
            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste instancia";
            Log log2 = Log.GetInstance(); // log2 recebe a mesma instancia de log
            System.Console.WriteLine(log2.PropriedadeLog);

            //Construtor herança
            Aluno a1 = new Aluno("Gabriel", "Soares", "Algoritmos");
            a1.Apresentar();

            //Get Set
            Data mes1 = new Data();
            mes1.Mes = 20; // 20 -> value
            mes1.ApresentarMes();
            Data mes2 = new Data();
            mes2.Mes = 3; // 3 -> value
            mes2.ApresentarMes();

            //Delegate
            Operacao op = new Operacao(Calculadora.Somar); //Passa ao delegate o metodo somar.
            op += Calculadora.Subtrair; //Adiciona outro metodo ao delegate.
            op.Invoke(10,10); // Usa o delegate.

        }      
    }
}
