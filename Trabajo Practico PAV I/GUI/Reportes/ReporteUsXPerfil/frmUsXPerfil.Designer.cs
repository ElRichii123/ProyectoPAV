
namespace Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil
{
    partial class frmUsXPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsXPerfil));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsUsXPerfil = new Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil.DsUsXPerfil();
            this.dtblUsXPerfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtblUsXPerfilTableAdapter = new Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil.DsUsXPerfilTableAdapters.dtblUsXPerfilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsUsXPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUsXPerfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tablaUsXPerfil";
            reportDataSource1.Value = this.dtblUsXPerfilBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil.rptUsXPerfil.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(65535, 65535);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsUsXPerfil
            // 
            this.DsUsXPerfil.DataSetName = "DsUsXPerfil";
            this.DsUsXPerfil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtblUsXPerfilBindingSource
            // 
            this.dtblUsXPerfilBindingSource.DataMember = "dtblUsXPerfil";
            this.dtblUsXPerfilBindingSource.DataSource = this.DsUsXPerfil;
            // 
            // dtblUsXPerfilTableAdapter
            // 
            this.dtblUsXPerfilTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsXPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsXPerfil";
            this.Text = "Reporte Usuarios por Perfil";
            this.Load += new System.EventHandler(this.frmUsXPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsUsXPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUsXPerfilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtblUsXPerfilBindingSource;
        private DsUsXPerfil DsUsXPerfil;
        private DsUsXPerfilTableAdapters.dtblUsXPerfilTableAdapter dtblUsXPerfilTableAdapter;
    }
}