
namespace Trabajo_Practico_PAV_I.GUI
{
    partial class frmNuevoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoFormulario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPerfiles = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.cmbNombreForm = new System.Windows.Forms.ComboBox();
            this.btnPermitirAcceso = new System.Windows.Forms.Button();
            this.btnRemoverAcceso = new System.Windows.Forms.Button();
            this.grdPermisos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Nombre del Formulario:";
            // 
            // lblPerfiles
            // 
            this.lblPerfiles.AutoSize = true;
            this.lblPerfiles.Location = new System.Drawing.Point(474, 67);
            this.lblPerfiles.Name = "lblPerfiles";
            this.lblPerfiles.Size = new System.Drawing.Size(33, 13);
            this.lblPerfiles.TabIndex = 31;
            this.lblPerfiles.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(513, 64);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(94, 21);
            this.cmbPerfil.TabIndex = 30;
            // 
            // cmbNombreForm
            // 
            this.cmbNombreForm.FormattingEnabled = true;
            this.cmbNombreForm.Location = new System.Drawing.Point(141, 64);
            this.cmbNombreForm.Name = "cmbNombreForm";
            this.cmbNombreForm.Size = new System.Drawing.Size(94, 21);
            this.cmbNombreForm.TabIndex = 32;
            // 
            // btnPermitirAcceso
            // 
            this.btnPermitirAcceso.Location = new System.Drawing.Point(191, 484);
            this.btnPermitirAcceso.Name = "btnPermitirAcceso";
            this.btnPermitirAcceso.Size = new System.Drawing.Size(113, 23);
            this.btnPermitirAcceso.TabIndex = 33;
            this.btnPermitirAcceso.Text = "Permitir Acceso";
            this.btnPermitirAcceso.UseVisualStyleBackColor = true;
            this.btnPermitirAcceso.Click += new System.EventHandler(this.btnPermitirAcceso_Click);
            // 
            // btnRemoverAcceso
            // 
            this.btnRemoverAcceso.Location = new System.Drawing.Point(359, 484);
            this.btnRemoverAcceso.Name = "btnRemoverAcceso";
            this.btnRemoverAcceso.Size = new System.Drawing.Size(113, 23);
            this.btnRemoverAcceso.TabIndex = 34;
            this.btnRemoverAcceso.Text = "Remover Acceso";
            this.btnRemoverAcceso.UseVisualStyleBackColor = true;
            this.btnRemoverAcceso.Click += new System.EventHandler(this.btnRemoverAcceso_Click);
            // 
            // grdPermisos
            // 
            this.grdPermisos.AllowUserToAddRows = false;
            this.grdPermisos.AllowUserToOrderColumns = true;
            this.grdPermisos.AllowUserToResizeRows = false;
            this.grdPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPermisos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPermisos.GridColor = System.Drawing.SystemColors.Control;
            this.grdPermisos.Location = new System.Drawing.Point(32, 91);
            this.grdPermisos.Name = "grdPermisos";
            this.grdPermisos.ReadOnly = true;
            this.grdPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdPermisos.Size = new System.Drawing.Size(650, 304);
            this.grdPermisos.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Formularios";
            // 
            // frmNuevoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdPermisos);
            this.Controls.Add(this.btnRemoverAcceso);
            this.Controls.Add(this.btnPermitirAcceso);
            this.Controls.Add(this.cmbNombreForm);
            this.Controls.Add(this.lblPerfiles);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNuevoFormulario";
            this.Text = "Formularios";
            this.Load += new System.EventHandler(this.frmNuevoFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPerfiles;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ComboBox cmbNombreForm;
        private System.Windows.Forms.Button btnPermitirAcceso;
        private System.Windows.Forms.Button btnRemoverAcceso;
        private System.Windows.Forms.DataGridView grdPermisos;
        private System.Windows.Forms.Label label1;
    }
}