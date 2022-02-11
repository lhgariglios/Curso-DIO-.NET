using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Construtores.Modelos
{
    internal class Calculadora
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}.");
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}.");
        }
    }
}
