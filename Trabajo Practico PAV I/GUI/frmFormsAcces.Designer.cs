
namespace Trabajo_Practico_PAV_I.GUI
{
    partial class frmFormsAcces
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
            this.dgvFormularios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormularios
            // 
            this.dgvFormularios.AllowUserToAddRows = false;
            this.dgvFormularios.AllowUserToDeleteRows = false;
            this.dgvFormularios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormularios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFormularios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFormularios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFormularios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormularios.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFormularios.Location = new System.Drawing.Point(12, 59);
            this.dgvFormularios.Name = "dgvFormularios";
            this.dgvFormularios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFormularios.RowHeadersVisible = false;
            this.dgvFormularios.Size = new System.Drawing.Size(703, 458);
            this.dgvFormularios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formularios a los que tiene acceso:";
            // 
            // frmFormsAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFormularios);
            this.MaximizeBox = false;
            this.Name = "frmFormsAcces";
            this.Text = "Formularios accesibles";
            this.Load += new System.EventHandler(this.frmFormsAcces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormularios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormularios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}