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
        public Parental()
        {
            this.configuracion = new ConfigCreator();
            //this.ExisteRegistro("ejemplo.com");
        }
        /**
         *  RESTRINGE UN SITIO POR TIEMPO INDEFINIDO
         *  DEVUELVE TRUE SI SE HA RESTRINGIDO Y FALSO DE LO CONTRARIO
         */
        public bool RestringeSitio(String url)
        {
            if (this.ExisteRegistro(url))
            {
                return false;
            }
            else
            {
                //ANADIRLO AL ARCHIVO HOST
                this.AgregaSitio(url);
                return true;
            }
        }
        /**
         * RESTRINGE UN SITIO APLICANDO UN TIPO DE PERFIL
         */
        public bool RestringeSitio(Perfil regis)
        {
            if (this.ExisteRegistro(regis.url))
            {
                return false;
            }
            else
            {
                List<Perfil> listPerfiles = this.GetListaPerfiles();
                listPerfiles.Add(regis);
                String textoJson = JsonConvert.SerializeObject(listPerfiles, Formatting.Indented);

                File.WriteAllText(this.configuracion.rutaPerfiles, textoJson);
                using (StreamWriter sw = File.AppendText(HOST_FILE))
                {
                    sw.WriteLine($"127.0.0.1 {regis.url}");
                    sw.Close();
                }
                return true;
            }

        }

        private void AgregaSitio(String url)
        {
            using (StreamWriter sw = File.AppendText(HOST_FILE))
            {
                sw.WriteLine($"127.0.0.1 {url}");
                sw.Close();
            }
            Perfil p = new Perfil();
            p.indefinido = true;
            p.url = url;

            List<Perfil> listaPerfiles = this.GetListaPerfiles();
            listaPerfiles.Add(p);

            String textoJson = JsonConvert.SerializeObject(listaPerfiles, Formatting.Indented);

            File.WriteAllText(this.configuracion.rutaPerfiles, textoJson);
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
         *      VALIDACIONES DE REGISTROS
         */
        private bool ExisteRegistro(String url)
        {
            //VERIFICAR SI EXISTE EN EL ARCHIVO JSON            
            List<Perfil> perfiles = this.GetListaPerfiles();
            
            bool encontrado = false;
            for (var i = 0; i < perfiles.Count; i++)
            {
                if (perfiles[i].url.Equals(url))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }

}


