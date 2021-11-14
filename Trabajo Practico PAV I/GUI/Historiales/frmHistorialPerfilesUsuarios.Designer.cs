
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
            this.grdHistorialPerfilesUsuarios.Size = new System.Drawing.Size(674, 482);
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
            // frmHistorialPerfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
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
    }
}