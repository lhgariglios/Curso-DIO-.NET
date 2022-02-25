using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSeries
{
    public class Serie: Base
    {
        private Generos genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int lancamento { get; set; }
        private bool excluido { get; set; }

        public Serie(int Id, Generos genero, string titulo, string descricao, int lancamento)
        {
            this.Id = Id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.lancamento = lancamento;
            this.excluido = false;
        }  
        public void Excluir() 
        {
            this.excluido = true;
        }
        public string Titulo()
        {
            return this.titulo;
        }
        public int Indice()
        {
            return this.Id;
        }
        public bool Excluido()
        {
            return this.excluido;
        }
        public int Ano()
        {
            return lancamento;
        }
        public string Descricao()
        {
            return descricao;
        }
        public Generos Genero()
        {
            return genero;
        }
    }
}
