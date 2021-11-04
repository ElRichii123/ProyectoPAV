
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
            this.grdHistorialPerfilesUsuarios = new System.Windows.Forms.DataGridView();
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
            this.grdHistorialPerfilesUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorialPerfilesUsuarios.Location = new System.Drawing.Point(258, 12);
            this.grdHistorialPerfilesUsuarios.Name = "grdHistorialPerfilesUsuarios";
            this.grdHistorialPerfilesUsuarios.ReadOnly = true;
            this.grdHistorialPerfilesUsuarios.Size = new System.Drawing.Size(461, 426);
            this.grdHistorialPerfilesUsuarios.TabIndex = 37;
            
            // 
            // frmHistorialPerfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdHistorialPerfilesUsuarios);
            this.Name = "frmHistorialPerfilesUsuarios";
            this.Text = "frmHistorialPerfilesUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPerfilesUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorialPerfilesUsuarios;
    }
}