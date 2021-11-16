
namespace Trabajo_Practico_PAV_I
{
    partial class HistorialPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPermisos));
            this.grdHistorialPermisos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxPerfil = new System.Windows.Forms.ComboBox();
            this.cmbBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.mskFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHistorialPermisos
            // 
            this.grdHistorialPermisos.AllowUserToAddRows = false;
            this.grdHistorialPermisos.AllowUserToOrderColumns = true;
            this.grdHistorialPermisos.AllowUserToResizeRows = false;
            this.grdHistorialPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistorialPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdHistorialPermisos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdHistorialPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdHistorialPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHistorialPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorialPermisos.GridColor = System.Drawing.SystemColors.Control;
            this.grdHistorialPermisos.Location = new System.Drawing.Point(28, 44);
            this.grdHistorialPermisos.Name = "grdHistorialPermisos";
            this.grdHistorialPermisos.ReadOnly = true;
            this.grdHistorialPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHistorialPermisos.RowHeadersVisible = false;
            this.grdHistorialPermisos.Size = new System.Drawing.Size(662, 250);
            this.grdHistorialPermisos.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Historial de Permisos de Formularios";
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(68, 480);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 58;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click_1);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(149, 480);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 57;
            this.btnAplicar.Text = "Aplicar Filtro";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Perfil:";
            // 
            // cmbBoxPerfil
            // 
            this.cmbBoxPerfil.FormattingEnabled = true;
            this.cmbBoxPerfil.Items.AddRange(new object[] {
            "Usuario",
            "Fecha"});
            this.cmbBoxPerfil.Location = new System.Drawing.Point(101, 370);
            this.cmbBoxPerfil.Name = "cmbBoxPerfil";
            this.cmbBoxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPerfil.TabIndex = 51;
            // 
            // cmbBoxFiltro
            // 
            this.cmbBoxFiltro.FormattingEnabled = true;
            this.cmbBoxFiltro.Items.AddRange(new object[] {
            "Perfil",
            "Fecha"});
            this.cmbBoxFiltro.Location = new System.Drawing.Point(101, 334);
            this.cmbBoxFiltro.Name = "cmbBoxFiltro";
            this.cmbBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFiltro.TabIndex = 50;
            this.cmbBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Filtrar por:";
            // 
            // mskFechaDesde
            // 
            this.mskFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFechaDesde.Location = new System.Drawing.Point(101, 408);
            this.mskFechaDesde.Name = "mskFechaDesde";
            this.mskFechaDesde.Size = new System.Drawing.Size(123, 20);
            this.mskFechaDesde.TabIndex = 59;
            this.mskFechaDesde.Value = new System.DateTime(2021, 1, 1, 12, 7, 0, 0);
            // 
            // mskFechaHasta
            // 
            this.mskFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskFechaHasta.Location = new System.Drawing.Point(101, 442);
            this.mskFechaHasta.Name = "mskFechaHasta";
            this.mskFechaHasta.Size = new System.Drawing.Size(123, 20);
            this.mskFechaHasta.TabIndex = 60;
            this.mskFechaHasta.Value = new System.DateTime(2021, 1, 1, 12, 7, 0, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(229, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Aplicar ambos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HistorialPermisos
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
            this.Controls.Add(this.cmbBoxPerfil);
            this.Controls.Add(this.cmbBoxFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdHistorialPermisos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialPermisos";
            this.Text = "Historial de Permisos";
            this.Load += new System.EventHandler(this.HistorialPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorialPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxPerfil;
        private System.Windows.Forms.ComboBox cmbBoxFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker mskFechaDesde;
        private System.Windows.Forms.DateTimePicker mskFechaHasta;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}