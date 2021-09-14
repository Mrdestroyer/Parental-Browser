using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parental_Browser.Scripts;

namespace Parental_Browser
{
    public partial class FormPrincipal : Form
    {
        private Parental parental;

        public FormPrincipal()
        {
            
            InitializeComponent();
            this.parental = new Parental();
            this.setRegistrosEnTabla();
        }
        public void setRegistrosEnTabla()
        {
            List<Perfil> perfiles = this.parental.GetListaPerfiles();
            
            for(int i = 0; i < perfiles.Count; i++)
            {
                Perfil actu = perfiles[i];
                String dias = "";
                if (!actu.EsIndefinido)
                {
                    dias = string.Join(", ", this.parental.GetNombreDiasDeEnteros(actu.Dias));
                }
                this.tablaData.Rows.Add(actu.Url, actu.EsIndefinido, dias, actu.HoraInicio, actu.HoraFin);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.checkIndefinido.Checked)
            {
                int cant = this.listaDias.CheckedItems.Count;
                if(this.listaDias.CheckedItems.Count > 0)
                {
                    String url = this.input_url.Text;
                    int horaInicio = (int)this.inputHoraInit.Value;
                    int horaFin = (int)this.InputHoraFin.Value;
                    int[] dias = new int[this.listaDias.CheckedItems.Count];
                    int cuenta = 0;

                    Regex rgx = new Regex(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");
                    if (!rgx.IsMatch(url))
                    {
                        MessageBox.Show("Ingrese una url valida!");
                        return;
                    }
                    //OBTENER LOS DIAS SELECCIONADO DONDE LUNES CORRESPONDE AL DIA 1
                    for (int i = 0; i < this.listaDias.Items.Count; i++)
                    {
                        if (this.listaDias.GetItemChecked(i))
                        {
                            dias[cuenta] = i + 1;
                            cuenta++;
                        }
                    }

                    Perfil perfil = new Perfil(url, dias, horaInicio, horaFin);
                    this.parental.RestringeSitio(perfil);
                    this.setRegistrosEnTabla();
                }
                else
                {
                    MessageBox.Show("Debes establecer los dias");
                    return;
                }

            }
            

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
