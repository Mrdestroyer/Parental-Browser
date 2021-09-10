using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Browser.Scripts
{
    class Parental
    {
        public const String HOST_FILE = @"C:\Windows\System32\drivers\etc\hosts";
        private ConfigCreator configuracion;
        private ParentalController PController;
        public Parental()
        {
            this.configuracion = new ConfigCreator();
            this.PController = new ParentalController();
        }
        /**
         * AGREA UN PERFIL AL ARCHIVO DE PERFILES Y PONE EN FUNCION EL PERFIL SI ESTE APLICA
         */
        public void RestringeSitio(Perfil regis)
        {
            if(this.ExisteRegistro(regis.Url))
            {
                return;
            }
            try
            {
                Validaciones.ValidaPerfil(regis);
                List<Perfil> listPerfiles = this.GetListaPerfiles();

                listPerfiles.Add(regis);

                this.ReemplazaPerfiles(listPerfiles);

            }catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /**
         * ACTIVA LA RESTRICCION DE UN SITIO QUE YA SE ENCUENTRA EN EL ARCHIVO DE CONFIGURACION
         * PASANDO ESTE METODO LA URL AL ARCHIVO HOST
         */
        public void ActivaRestriccion(String urlParam)
        {
            List<Perfil> listaPerfiles = this.GetListaPerfiles();
            for(var i = 0; i < listaPerfiles.Count; i++)
            {
                if (listaPerfiles[i].Url.Equals(urlParam))
                {
                    //CAMBIAR EL ESTADO A ACTIVO
                    listaPerfiles[i].EstaActivo = true;
                    this.ReemplazaPerfiles(listaPerfiles);
                    this.AgregaEnHost(listaPerfiles[i].Url);
                }
            }
        }
        /**
         * (DESACTIVAR LA RESTRICCION ) PONER EL ESTADO ACTIVO A FALSO Y ELIMINARLO DEL ARCHIVO HOST
         */
        public void DesactivaRestriccion(String urlParam)
        {
            List<Perfil> listPerfiles = this.GetListaPerfiles();
            for(var i = 0; i < listPerfiles.Count; i++)
            {
                if (listPerfiles[i].Url.Equals(urlParam))
                {
                    listPerfiles[i].EstaActivo = false;
                    //ELIMINAR DEL ARCHIVO HOST
                    List<String> lineasHost = File.ReadAllLines(HOST_FILE).ToList();

                    for (var j = 0; j < lineasHost.Count; j++)
                    {
                        if(lineasHost[j].IndexOf(listPerfiles[i].Url) != -1)
                        {
                            lineasHost.RemoveAt(j);
                            String[] lineasArray = lineasHost.ToArray();
                            //VOLVER EL ARCHIVO HOST A SU ESTADO NORMAL
                            File.WriteAllLines(HOST_FILE, lineasArray);

                            //AGREGAR LA LISTA AL ARCHIVO DE PERFILES
                            this.ReemplazaPerfiles(listPerfiles);
                            break;
                        }
                    }
                    break;
                }
            }
        }
        private void AgregaEnHost(String url)
        {
            using (StreamWriter sw = File.AppendText(HOST_FILE))
            {
                sw.WriteLine($"127.0.0.1 {url}");
                sw.Close();
            }
        }
        private void AgregaEnPerfiles(Perfil perfil)
        {
            List<Perfil> listaPerfiles = this.GetListaPerfiles();
            listaPerfiles.Add(perfil);

            String textoJson = JsonConvert.SerializeObject(listaPerfiles, Formatting.Indented);
            File.WriteAllText(this.configuracion.rutaPerfiles, textoJson);
        }
        //ACTUALIZA TODO EL ARCHIVO DE CONFIGURACION POR UNA LISTA DE PERFILES
        private void ReemplazaPerfiles(List<Perfil> perfiles)
        {
            foreach(Perfil per in perfiles)
            {
                Validaciones.ValidaPerfil(per);
            }
            String textoPerfiles = JsonConvert.SerializeObject(perfiles, Formatting.Indented);
            File.WriteAllText(this.configuracion.rutaPerfiles, textoPerfiles);
        }
        /**
         *      VALIDACIONES DE REGISTROS
         */
        private bool ExisteRegistro(String url)
        {
            //VERIFICAR SI EXISTE EN EL ARCHIVO JSON            
            List<Perfil> perfiles = this.GetListaPerfiles();
            
            bool encontrado = false;
            for (var i = 0; i < perfiles.Count; i++)
            {
                if (perfiles[i].Url.Equals(url))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public List<Perfil> GetListaPerfiles()
        {
            StreamReader r = new StreamReader(this.configuracion.rutaPerfiles);
            String texto = r.ReadToEnd();
            r.Close();
            List<Perfil> perfiles = JsonConvert.DeserializeObject<List<Perfil>>(texto);

            return perfiles;
        }

        /**
         * DEVUELVE TRUE SI EL PERFIL APLICA(SE ENCUENTRA DENTRO DEL RANGO DE HORA, DIA ETC)
         */
        public bool AplicaPerfil(Perfil perfil)
        {
            DateTime f = DateTime.Now;
            int diaHoy = (int)f.DayOfWeek;
            //PARA PERFILES INDEFINIDOS
            if (perfil.EsIndefinido)
            {
                return true;
            }
            //COMPROBAR SI EL PERFIL APLICA A LA HORA Y DIA ACTUAL
            if (perfil.Dias.Contains(diaHoy) && f.Hour >= perfil.HoraInicio && f.Hour <= perfil.HoraFin && !perfil.EstaActivo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}


