
using System;

namespace Trabajo_Practico_PAV_I
{
    partial class frmNuevoPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPerfil));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdPerfiles = new System.Windows.Forms.DataGridView();
            this.btnAgregarBug = new System.Windows.Forms.Button();
            this.btnActualizarBug = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnConsultarPerfil = new System.Windows.Forms.Button();
            this.btnEliminarPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(18, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(90, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre del Perfil:";
            // 
            // grdPerfiles
            // 
            this.grdPerfiles.AllowUserToAddRows = false;
            this.grdPerfiles.AllowUserToOrderColumns = true;
            this.grdPerfiles.AllowUserToResizeRows = false;
            this.grdPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerfiles.Location = new System.Drawing.Point(237, 37);
            this.grdPerfiles.Name = "grdPerfiles";
            this.grdPerfiles.ReadOnly = true;
            this.grdPerfiles.Size = new System.Drawing.Size(216, 161);
            this.grdPerfiles.TabIndex = 8;
            this.grdPerfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBugs_CellClick);
            // 
            // btnAgregarBug
            // 
            this.btnAgregarBug.Location = new System.Drawing.Point(21, 146);
            this.btnAgregarBug.Name = "btnAgregarBug";
            this.btnAgregarBug.Size = new System.Drawing.Size(102, 23);
            this.btnAgregarBug.TabIndex = 11;
            this.btnAgregarBug.Text = "Agregar Perfil";
            this.btnAgregarBug.UseVisualStyleBackColor = true;
            this.btnAgregarBug.Click += new System.EventHandler(this.btnAgregarBug_Click);
            // 
            // btnActualizarBug
            // 
            this.btnActualizarBug.Location = new System.Drawing.Point(21, 117);
            this.btnActualizarBug.Name = "btnActualizarBug";
            this.btnActualizarBug.Size = new System.Drawing.Size(102, 23);
            this.btnActualizarBug.TabIndex = 19;
            this.btnActualizarBug.Text = "Actualizar Perfil";
            this.btnActualizarBug.UseVisualStyleBackColor = true;
            this.btnActualizarBug.Click += new System.EventHandler(this.btnActualizarBug_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnConsultarPerfil
            // 
            this.btnConsultarPerfil.Location = new System.Drawing.Point(21, 88);
            this.btnConsultarPerfil.Name = "btnConsultarPerfil";
            this.btnConsultarPerfil.Size = new System.Drawing.Size(102, 23);
            this.btnConsultarPerfil.TabIndex = 20;
            this.btnConsultarPerfil.Text = "Consultar Perfil";
            this.btnConsultarPerfil.UseVisualStyleBackColor = true;
            this.btnConsultarPerfil.Click += new System.EventHandler(this.btnConsultarPerfil_Click);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.Location = new System.Drawing.Point(21, 175);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarPerfil.TabIndex = 21;
            this.btnEliminarPerfil.Text = "Eliminar Perfil";
            this.btnEliminarPerfil.UseVisualStyleBackColor = true;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // frmNuevoPerfil
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 249);
            this.Controls.Add(this.btnEliminarPerfil);
            this.Controls.Add(this.btnConsultarPerfil);
            this.Controls.Add(this.btnActualizarBug);
            this.Controls.Add(this.btnAgregarBug);
            this.Controls.Add(this.grdPerfiles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmNuevoPerifl_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdPerfiles;
        private System.Windows.Forms.Button btnAgregarBug;
        private System.Windows.Forms.Button btnActualizarBug;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConsultarPerfil;
        private System.Windows.Forms.Button btnEliminarPerfil;
    }
}