using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Browser.Scripts
{
    class Validaciones
    {
        public static void ValidaPerfil(Perfil perfil)
        {
            foreach(int dia in perfil.Dias)
            {
                if(dia > 7 || dia < 1)
                {
                    throw new ArgumentOutOfRangeException("Rango no valido de dias");
                }
            }
            if (perfil.HoraInicio > perfil.HoraFin || perfil.HoraInicio > 23 || perfil.HoraFin > 23 ||
                perfil.HoraInicio < 0 || perfil.HoraFin < 0)
            {
                throw new ArgumentOutOfRangeException("La hora establecida no tiene un formato correcto");
            }
        }
    }
}
