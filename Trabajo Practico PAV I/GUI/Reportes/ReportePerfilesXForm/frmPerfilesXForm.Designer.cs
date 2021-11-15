
namespace Trabajo_Practico_PAV_I.GUI.Reportes.ReportePerfilesXForm
{
    partial class frmPerfilesXForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cboFormularios = new System.Windows.Forms.ComboBox();
            this.txtFormularios = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsPerfilesXForm = new Trabajo_Practico_PAV_I.GUI.Reportes.ReportePerfilesXForm.DsPerfilesXForm();
            this.rpvPerfilesXForm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ckbForms = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsPerfilesXForm)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFormularios
            // 
            this.cboFormularios.FormattingEnabled = true;
            this.cboFormularios.Items.AddRange(new object[] {
            "TODOS"});
            this.cboFormularios.Location = new System.Drawing.Point(78, 14);
            this.cboFormularios.Name = "cboFormularios";
            this.cboFormularios.Size = new System.Drawing.Size(121, 21);
            this.cboFormularios.TabIndex = 0;
            // 
            // txtFormularios
            // 
            this.txtFormularios.AutoSize = true;
            this.txtFormularios.Location = new System.Drawing.Point(9, 17);
            this.txtFormularios.Name = "txtFormularios";
            this.txtFormularios.Size = new System.Drawing.Size(63, 13);
            this.txtFormularios.TabIndex = 1;
            this.txtFormularios.Text = "Formularios:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(589, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(126, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DsPerfilesXForm;
            // 
            // DsPerfilesXForm
            // 
            this.DsPerfilesXForm.DataSetName = "DsPerfilesXForm";
            this.DsPerfilesXForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvPerfilesXForm
            // 
            reportDataSource1.Name = "DsPerfilesxForm";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpvPerfilesXForm.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPerfilesXForm.LocalReport.ReportEmbeddedResource = "Trabajo_Practico_PAV_I.GUI.Reportes.ReportePerfilesXForm.rptPerfilesXForm.rdlc";
            this.rpvPerfilesXForm.Location = new System.Drawing.Point(12, 45);
            this.rpvPerfilesXForm.Name = "rpvPerfilesXForm";
            this.rpvPerfilesXForm.ServerReport.BearerToken = null;
            this.rpvPerfilesXForm.Size = new System.Drawing.Size(703, 65535);
            this.rpvPerfilesXForm.TabIndex = 3;
            // 
            // ckbForms
            // 
            this.ckbForms.AutoSize = true;
            this.ckbForms.Location = new System.Drawing.Point(249, 16);
            this.ckbForms.Name = "ckbForms";
            this.ckbForms.Size = new System.Drawing.Size(123, 17);
            this.ckbForms.TabIndex = 4;
            this.ckbForms.Text = "Seleccionar TODOS";
            this.ckbForms.UseVisualStyleBackColor = true;
            this.ckbForms.CheckedChanged += new System.EventHandler(this.ckbForms_CheckedChanged);
            // 
            // frmPerfilesXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 529);
            this.Controls.Add(this.ckbForms);
            this.Controls.Add(this.rpvPerfilesXForm);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtFormularios);
            this.Controls.Add(this.cboFormularios);
            this.Name = "frmPerfilesXForm";
            this.Text = "frmPerfilesXForm";
            this.Load += new System.EventHandler(this.frmPerfilesXForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsPerfilesXForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFormularios;
        private System.Windows.Forms.Label txtFormularios;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DsPerfilesXForm DsPerfilesXForm;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPerfilesXForm;
        private System.Windows.Forms.CheckBox ckbForms;
    }
}