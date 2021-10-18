
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdPerfiles = new System.Windows.Forms.DataGridView();
            this.lblPerfiles = new System.Windows.Forms.Label();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Nombre del Formulario:";
            // 
            // grdPerfiles
            // 
            this.grdPerfiles.AllowUserToAddRows = false;
            this.grdPerfiles.AllowUserToOrderColumns = true;
            this.grdPerfiles.AllowUserToResizeRows = false;
            this.grdPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerfiles.Location = new System.Drawing.Point(141, 112);
            this.grdPerfiles.Name = "grdPerfiles";
            this.grdPerfiles.ReadOnly = true;
            this.grdPerfiles.Size = new System.Drawing.Size(216, 161);
            this.grdPerfiles.TabIndex = 9;
            // 
            // lblPerfiles
            // 
            this.lblPerfiles.AutoSize = true;
            this.lblPerfiles.Location = new System.Drawing.Point(295, 42);
            this.lblPerfiles.Name = "lblPerfiles";
            this.lblPerfiles.Size = new System.Drawing.Size(33, 13);
            this.lblPerfiles.TabIndex = 31;
            this.lblPerfiles.Text = "Perfil:";
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(358, 42);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(94, 21);
            this.cboPerfiles.TabIndex = 30;
            // 
            // frmNuevoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 332);
            this.Controls.Add(this.lblPerfiles);
            this.Controls.Add(this.cboPerfiles);
            this.Controls.Add(this.grdPerfiles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNuevoFormulario";
            this.Text = "Formularios";
            this.Load += new System.EventHandler(this.frmNuevoFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdPerfiles;
        private System.Windows.Forms.Label lblPerfiles;
        private System.Windows.Forms.ComboBox cboPerfiles;
    }
}