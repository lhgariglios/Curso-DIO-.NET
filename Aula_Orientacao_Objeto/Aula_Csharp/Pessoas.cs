﻿using System;

namespace Aula_Orientacao_Objeto
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome} e tenho {Idade} anos.");
        }
    }
}
