
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
            this.grdHistorialPermisos.Size = new System.Drawing.Size(662, 473);
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
            // HistorialPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
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
    }
}