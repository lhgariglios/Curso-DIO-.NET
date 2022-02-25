using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSeries
{
    internal interface IBaseSeries<T>
    {
        List<T> Lista();
        void Atualiza(int Id, T entidade);
        void Excluir(int Id);
        void Inserir(T entidade);
        int ProximoIndice();
        T RetornaPorIndice(int Id);

    }
}
