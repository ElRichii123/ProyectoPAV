
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
            this.grdHistorialPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorialPermisos.Location = new System.Drawing.Point(57, 12);
            this.grdHistorialPermisos.Name = "grdHistorialPermisos";
            this.grdHistorialPermisos.ReadOnly = true;
            this.grdHistorialPermisos.Size = new System.Drawing.Size(392, 426);
            this.grdHistorialPermisos.TabIndex = 36;
            // 
            // HistorialPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.grdHistorialPermisos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialPermisos";
            this.Text = "Historial de Permisos";
            this.Load += new System.EventHandler(this.HistorialPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorialPermisos;
    }
}