using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientacao_Objeto
{
    internal class Retangulo
    {
        private double comprimento; // Argumentos privados
        private double largura;
        private double area;

        public void DefinirMedidas(double comprimento, double largura) // Permite alterar os argumentos acima
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
            }
            else
            {
                System.Console.WriteLine("Valores invalidos!");
            }
        }

        public double ObterArea()
        {
            area = comprimento * largura;
            return area;
        }
    }
}
