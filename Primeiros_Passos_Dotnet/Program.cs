// Primeiros passos .Net
using System;

namespace PrimeirosPassos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção: "); //Pula a linha
            Console.WriteLine("1- Novo aluno");
            Console.WriteLine("2- Lista de alunos");
            Console.WriteLine("3- Media geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine(); //Deixar linha em branco

            string opcao = Console.ReadLine(); //Lê o que foi digitado

            while (opcao.ToUpper != "X") // Transforma em maiúsculo
            {
                switch(opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(); //Mostra erro
                }
                Console.WriteLine("Digite a opção: "); //Pula a linha
                Console.WriteLine("1- Novo aluno");
                Console.WriteLine("2- Lista de alunos");
                Console.WriteLine("3- Media geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine(); 

                opcao = Console.ReadLine();
            }
        }
    }
}
