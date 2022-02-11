using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Construtores.Modelos
{
    internal class Aluno : Pessoa
    {
        // Uma classe filha herda o construtor definido na classe mãe
        // base -> se refere a itens, parâmetros da classe mãe
        public Aluno(string nome, string sobrenome, string disciplina) : base (nome, sobrenome)
        {

        }
    }
}
