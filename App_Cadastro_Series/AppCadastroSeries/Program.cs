using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSeries
{
    class program
    {
        static Series ListaSeries = new Series(); 
        static void Main(string[] args)
        {
            int acao = 0;
            
            while (acao != 6)
            {
                Inicio();
                acao = int.Parse(Console.ReadLine());
                if (acao == 1) 
                {
                    Imprimir_Series();
                }
                else if(acao == 2) 
                {
                    Nova_Serie();
                }
                else if (acao == 3) 
                {
                    Atualizar_Serie();
                }
                else if (acao == 4) 
                {
                    Excluir_Serie();
                }
                else if (acao == 5) 
                {
                    Exibir_serie();
                }
                else if (acao == 6) 
                {
                    Console.WriteLine("Saindo...");
                }
                else 
                {
                    Console.WriteLine("Digite uma entrada valida! ");
                }

            }
        }
        private static void Inicio()
        {
            Console.Clear();
            Console.WriteLine("Digite a acao que deseja realizar: ");
            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Exibir as informacoes de uma serie");
            Console.WriteLine("6 - Sair");
        }

        private static void Imprimir_Series()
        {
            Console.Clear();
            Console.WriteLine("Lista de series: ");

            var lista = ListaSeries.Lista();
            int sair = 0;
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie registrada!");
            }
            else
            {
                foreach (var serie in lista)
                {
                    bool excluido = serie.Excluido();
                    Console.WriteLine("Indice {0} - {1} - {2}", serie.Indice(), serie.Titulo(), (excluido ? "Excluida":" "));
                }
            }
            Console.WriteLine("Digite 1 para retornar a tela principal: ");
            sair = int.Parse(Console.ReadLine());
            if (sair == 1)
            {
                Console.WriteLine("Saindo...");
            }
        }
        private static void Nova_Serie()
        {
            int ano, genero;
            string nome, descricao;

            Console.Clear();
            Console.WriteLine("Inserir nova serie");

            Console.WriteLine("Digite o nome da serie: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite uma breve descricao da serie: ");
            descricao = Console.ReadLine();

            Console.WriteLine("Digite o ano em que a serie foi lancada: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Generos: ");

            foreach (int i in Enum.GetValues(typeof(Generos)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Generos), i));
            }

            Console.WriteLine("Digite o genero da serie dentre as opcoes acima: ");
            genero = int.Parse(Console.ReadLine());

            Serie serie = new Serie(ListaSeries.ProximoIndice(), (Generos)genero, nome, descricao, ano);
            ListaSeries.Inserir(serie);
        }
        private static void Excluir_Serie()
        {
            Console.Clear();
            Console.WriteLine("Digite o indice da serie que deseja excluir: ");
            var id = int.Parse(Console.ReadLine());
            ListaSeries.Excluir(id);
        }
        private static void Exibir_serie()
        {
            Console.Clear();
            Console.WriteLine("Digite o indice da serie que deseja exibir: ");
            var id = int.Parse(Console.ReadLine());

            var serie = ListaSeries.RetornaPorIndice(id);

            bool excluido = serie.Excluido();
            Console.WriteLine("{0} - {1} - {2}", serie.Indice(), serie.Titulo(), (excluido ? "Excluida" : " "));
            Console.WriteLine("Descricao: {0}", serie.Descricao());
            Console.WriteLine("Genero: {0} - Ano de lancamento: {1}", serie.Genero(), serie.Ano());

            int sair = 0;
            Console.WriteLine("Digite 1 para retornar a tela principal: ");
            sair = int.Parse(Console.ReadLine());
            if (sair == 1)
            {
                Console.WriteLine("Saindo...");
            }
        }
        private static void Atualizar_Serie()
        {
            int id, ano, genero;
            string nome, descricao;

            Console.Clear();
            
            Console.WriteLine("Digite o indice da serie que deseja atualizar: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite uma breve descricao da serie: ");
            descricao = Console.ReadLine();

            Console.WriteLine("Digite o ano em que a serie foi lancada: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Generos: ");

            foreach (int i in Enum.GetValues(typeof(Generos)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Generos), i));
            }

            Console.WriteLine("Digite o genero da serie dentre as opcoes acima: ");
            genero = int.Parse(Console.ReadLine());

            Serie serie = new Serie(id, (Generos)genero, nome, descricao, ano);
            ListaSeries.Atualiza(id, serie);
        }
    }
}

