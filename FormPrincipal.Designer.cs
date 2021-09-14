
namespace Parental_Browser
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.listaDias = new System.Windows.Forms.CheckedListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.InputHoraFin = new System.Windows.Forms.NumericUpDown();
            this.inputHoraInit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkIndefinido = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaData = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDEFINIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHoraInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 532);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 77);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 66);
            this.label1.TabIndex = 0;
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.listaDias);
            this.PanelHome.Controls.Add(this.btn_agregar);
            this.PanelHome.Controls.Add(this.InputHoraFin);
            this.PanelHome.Controls.Add(this.inputHoraInit);
            this.PanelHome.Controls.Add(this.label6);
            this.PanelHome.Controls.Add(this.label5);
            this.PanelHome.Controls.Add(this.label4);
            this.PanelHome.Controls.Add(this.checkIndefinido);
            this.PanelHome.Controls.Add(this.label3);
            this.PanelHome.Controls.Add(this.input_url);
            this.PanelHome.Controls.Add(this.label2);
            this.PanelHome.Controls.Add(this.tablaData);
            this.PanelHome.Location = new System.Drawing.Point(237, 13);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(785, 507);
            this.PanelHome.TabIndex = 1;
            // 
            // listaDias
            // 
            this.listaDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.listaDias.CheckOnClick = true;
            this.listaDias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDias.ForeColor = System.Drawing.Color.White;
            this.listaDias.FormattingEnabled = true;
            this.listaDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.listaDias.Location = new System.Drawing.Point(586, 13);
            this.listaDias.Name = "listaDias";
            this.listaDias.Size = new System.Drawing.Size(196, 172);
            this.listaDias.TabIndex = 18;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(359, 144);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(110, 41);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputHoraFin
            // 
            this.InputHoraFin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHoraFin.Location = new System.Drawing.Point(234, 108);
            this.InputHoraFin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.InputHoraFin.Name = "InputHoraFin";
            this.InputHoraFin.Size = new System.Drawing.Size(69, 29);
            this.InputHoraFin.TabIndex = 16;
            // 
            // inputHoraInit
            // 
            this.inputHoraInit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHoraInit.Location = new System.Drawing.Point(95, 108);
            this.inputHoraInit.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.inputHoraInit.Name = "inputHoraInit";
            this.inputHoraInit.Size = new System.Drawing.Size(69, 29);
            this.inputHoraInit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inicio:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(181, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fin:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(510, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias:";
            // 
            // checkIndefinido
            // 
            this.checkIndefinido.Location = new System.Drawing.Point(124, 63);
            this.checkIndefinido.Name = "checkIndefinido";
            this.checkIndefinido.Size = new System.Drawing.Size(104, 23);
            this.checkIndefinido.TabIndex = 4;
            this.checkIndefinido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Indefinido:";
            // 
            // input_url
            // 
            this.input_url.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_url.Location = new System.Drawing.Point(124, 18);
            this.input_url.Multiline = true;
            this.input_url.Name = "input_url";
            this.input_url.Size = new System.Drawing.Size(345, 23);
            this.input_url.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tablaData
            // 
            this.tablaData.AllowUserToAddRows = false;
            this.tablaData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL,
            this.INDEFINIDO,
            this.DIAS,
            this.HoraInicio,
            this.HoraFin});
            this.tablaData.Location = new System.Drawing.Point(4, 191);
            this.tablaData.Name = "tablaData";
            this.tablaData.ReadOnly = true;
            this.tablaData.Size = new System.Drawing.Size(778, 270);
            this.tablaData.TabIndex = 0;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // INDEFINIDO
            // 
            this.INDEFINIDO.HeaderText = "INDEFINIDO";
            this.INDEFINIDO.Name = "INDEFINIDO";
            this.INDEFINIDO.ReadOnly = true;
            // 
            // DIAS
            // 
            this.DIAS.HeaderText = "DIAS";
            this.DIAS.Name = "DIAS";
            this.DIAS.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "HoraInicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "HoraFin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1034, 532);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHoraInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.DataGridView tablaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDEFINIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.NumericUpDown InputHoraFin;
        private System.Windows.Forms.NumericUpDown inputHoraInit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkIndefinido;
        private System.Windows.Forms.CheckedListBox listaDias;
    }
}

