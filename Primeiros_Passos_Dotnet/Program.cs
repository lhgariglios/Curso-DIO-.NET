// Primeiros passos .Net
using System;

namespace PrimeirosPassos
{
	class Program
    {
        static void Main(string[] args)
        {
            string acao = OpcaoUsuario(); 

            while (acao != "4")
            {
                switch(acao)
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
                acao = OpcaoUsuario(); 
            }
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digite a opção: "); //Pula a linha
            Console.WriteLine("1- Novo aluno");
            Console.WriteLine("2- Lista de alunos");
            Console.WriteLine("3- Media geral");
            Console.WriteLine("4- Sair");
            Console.WriteLine(); //Deixar linha em branco

            string  opcaousuario = Console.ReadLine(); //Lê o que foi digitado
            return opcaousuario;
        }
    }
}
