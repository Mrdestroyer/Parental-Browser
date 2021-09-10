using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Browser.Scripts
{
    class Perfil
    {
        public bool EstaActivo { get; set; }
        public bool EsIndefinido { get; set; }
        public String Url { get; set; }
        public int[] Dias { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
    }
}
