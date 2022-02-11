using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Construtores.Modelos
{
    public class Log
    {
        private  static Log _log;
        public string PropriedadeLog { get; set; }
        private Log() //Construtor privado. Não pode ser usado para instanciar.
        {

        }

        public static Log GetInstance() //A mesma instância será usada em todo o projeto, apenas é criada uma vez.
        {
            if(_log == null)
            {
                _log = new Log(); //É possível instanciar pois está dentro da própria classe.
            }
            return _log;
        }
    }
}
