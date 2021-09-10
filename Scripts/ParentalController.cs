using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Browser.Scripts
{
    /**
     *  CLASE ENCARGADA DE ESTAR VERIFICANDO LAS REGLAS DE LOS PERFILES 
     *  SE EJECUTARA DE MANERA CONSTANTE PARA EL MANEJO DE LAS REGLAS DE MANERA AUTOMATICA
     * 
     * 
     */
    class ParentalController
    {
        private Parental parental;
        public ParentalController()
        {
            parental = new Parental();
        }
        /**
         *  EMPIEZAR A VERIFICAR LOS PERFILES CADA 30 SEGUNDOS
         */
        public void IniciaServicio()
        {
            Thread hiloServicio = new Thread(new ThreadStart(this.RunService));
            hiloServicio.Start();
        }
        private void RunService()
        {
            List<Perfil> perfiles = this.parental.GetListaPerfiles();
            foreach(Perfil per in perfiles)
            {
                if (this.parental.AplicaPerfil(per))
                {
                    this.parental.ActivaRestriccion(per.Url);

                }else if(!this.parental.AplicaPerfil(per) && per.EstaActivo)
                {
                    //DESACTIVAR
                    this.parental.DesactivaRestriccion(per.Url);
                }

            }
        }
        
    }
}













