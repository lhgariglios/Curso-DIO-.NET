using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Construtores.Modelos
{
    internal class Data
    {
        private int mes;
        private bool mesValido;

        public int Mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12) // verifica se o mes e valido
                {
                    this.mes = value; // value -> valor de entrada
                    this.mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mes invalido");
            }
        }
    }
}
