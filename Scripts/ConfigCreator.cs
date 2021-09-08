using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Browser.Scripts
{
    class ConfigCreator
    {
        private String folderAplicacion;
        private String nombreCarpeta;
        private String nombreArchivoPerfiles;
        public String rutaPerfiles { get; }

        public ConfigCreator()
        {
            this.nombreCarpeta = "ParentalB";
            this.folderAplicacion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +@"\"+ this.nombreCarpeta;
            
            this.nombreArchivoPerfiles = "Domains.json";
            //this.rutaPerfiles = this.obtieneRutaCompleta(this.nombreArchivoPerfiles);
            this.rutaPerfiles = @"./Domains.json";
        }

        public String GetGolderAplicacion()
        {
            return this.folderAplicacion;
        }
        
       //CREARA EL DIRECTORIO DE LA APLICACION SI ESTE NO SE HA CREADO
        public void creaDirectoriosIniciales()
        {
            if (!Directory.Exists(this.folderAplicacion))
            {
                Directory.CreateDirectory(this.folderAplicacion);
                File.WriteAllText(this.rutaPerfiles, "[\n\n]");
            }
            else
            {
                if (!File.Exists(this.rutaPerfiles))
                {
                    File.WriteAllText(this.rutaPerfiles, "[\n\n]");
                }
            }
        }

        private String obtieneRutaCompleta(String nombreArchivo)
        {
            return this.folderAplicacion + @"\" + nombreArchivo;
        }
    }
}
