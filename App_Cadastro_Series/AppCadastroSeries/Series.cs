using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSeries
{
    internal class Series : IBaseSeries<Serie>
    {
        private List<Serie> ListaSeries = new List<Serie>();
        public void Atualiza(int Id, Serie serie)
        {
            ListaSeries[Id] = serie;
        }

        public void Excluir(int Id)
        {
            ListaSeries[Id].Excluir();
        }

        public void Inserir(Serie serie)
        {
            ListaSeries.Add(serie);
        }

        public List<Serie> Lista()
        {
            return ListaSeries;
        }

        public int ProximoIndice()
        {
            return ListaSeries.Count;
        }

        public Serie RetornaPorIndice(int Id)
        {
            return ListaSeries[Id];
        }
    }
}
