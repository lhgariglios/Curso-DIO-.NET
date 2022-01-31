// Primeiros passos .Net
using System;

namespace PrimeirosPassos
{
	class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string acao = OpcaoUsuario(); 

            while (acao != "4")
            {
                switch(acao)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) //Verifica se é possível a conversão
                        {
                            //decimal.TryParse(Console.ReadLine()) --> Transforma a entrada string em decimal
                            aluno.Nota = nota;
                        }          
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!"); //Reporta erro
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var i in alunos) //Para cada
                        {
                            if(!string.IsNullOrEmpty(i.Nome))// Se o nome não é nulo ou vazio --> imprimir apenas o preenchido.
                            {
                                //$ --> Interpolação
                                Console.WriteLine($"Aluno: {i.Nome} - Nota: {i.Nota}");
                            }
                            
                        }
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
