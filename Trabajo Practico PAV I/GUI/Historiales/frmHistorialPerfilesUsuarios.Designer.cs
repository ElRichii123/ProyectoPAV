
namespace Trabajo_Practico_PAV_I.GUI
{
    partial class frmHistorialPerfilesUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialPerfilesUsuarios));
            this.grdHistorialPerfilesUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxFiltro = new System.Windows.Forms.ComboBox();
            this.cmbBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.mskFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.mskFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPerfilesUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHistorialPerfilesUsuarios
            // 
            this.grdHistorialPerfilesUsuarios.AllowUserToAddRows = false;
            this.grdHistorialPerfilesUsuarios.AllowUserToOrderColumns = true;
            this.grdHistorialPerfilesUsuarios.AllowUserToResizeRows = false;
            this.grdHistorialPerfilesUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistorialPerfilesUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdHistorialPerfilesUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdHistorialPerfilesUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdHistorialPerfilesUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHistorialPerfilesUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorialPerfilesUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.grdHistorialPerfilesUsuarios.Location = new System.Drawing.Point(24, 35);
            this.grdHistorialPerfilesUsuarios.Name = "grdHistorialPerfilesUsuarios";
            this.grdHistorialPerfilesUsuarios.ReadOnly = true;
            this.grdHistorialPerfilesUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHistorialPerfilesUsuarios.RowHeadersVisible = false;
            this.grdHistorialPerfilesUsuarios.Size = new System.Drawing.Size(674, 218);
            this.grdHistorialPerfilesUsuarios.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Historial  de Perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Filtrar por:";
            // 
            // cmbBoxFiltro
            // 
            this.cmbBoxFiltro.FormattingEnabled = true;
            this.cmbBoxFiltro.Items.AddRange(new object[] {
            "Usuario",
            "Fecha"});
            this.cmbBoxFiltro.Location = new System.Drawing.Point(81, 301);
            this.cmbBoxFiltro.Name = "cmbBoxFiltro";
            this.cmbBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFiltro.TabIndex = 40;
            this.cmbBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFiltro_SelectedIndexChanged);
            // 
            // cmbBoxUsuario
            // 
            this.cmbBoxUsuario.FormattingEnabled = true;
            this.cmbBoxUsuario.Items.AddRange(new object[] {
            "Usuario",
            "Fecha"});
            this.cmbBoxUsuario.Location = new System.Drawing.Point(81, 337);
            this.cmbBoxUsuario.Name = "cmbBoxUsuario";
            this.cmbBoxUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUsuario.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha Hasta:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(129, 447);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 47;
            this.btnAplicar.Text = "Aplicar Filtro";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(48, 447);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 48;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // mskFechaDesde
            // 
            this.mskFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFechaDesde.Location = new System.Drawing.Point(81, 375);
            this.mskFechaDesde.Name = "mskFechaDesde";
            this.mskFechaDesde.Size = new System.Drawing.Size(123, 20);
            this.mskFechaDesde.TabIndex = 60;
            this.mskFechaDesde.Value = new System.DateTime(2021, 1, 1, 12, 7, 0, 0);
            // 
            // mskFechaHasta
            // 
            this.mskFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFechaHasta.Location = new System.Drawing.Point(81, 409);
            this.mskFechaHasta.Name = "mskFechaHasta";
            this.mskFechaHasta.Size = new System.Drawing.Size(123, 20);
            this.mskFechaHasta.TabIndex = 61;
            this.mskFechaHasta.Value = new System.DateTime(2021, 1, 1, 12, 7, 0, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Aplicar ambos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmHistorialPerfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mskFechaHasta);
            this.Controls.Add(this.mskFechaDesde);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxUsuario);
            this.Controls.Add(this.cmbBoxFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdHistorialPerfilesUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialPerfilesUsuarios";
            this.Text = "Historial Perfiles de Usuarios";
            this.Load += new System.EventHandler(this.frmHistorialPerfilesUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPerfilesUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorialPerfilesUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxFiltro;
        private System.Windows.Forms.ComboBox cmbBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.DateTimePicker mskFechaDesde;
        private System.Windows.Forms.DateTimePicker mskFechaHasta;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}