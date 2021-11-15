using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_PAV_I.GUI.Reportes.ReportePerfilesXForm
{
    public partial class frmPerfilesXForm : Form
    {
        public frmPerfilesXForm()
        {
            InitializeComponent();
            LlenarCombo(cboFormularios, DataManager.GetInstance().ConsultaSQL("select * from Formularios where borrado = 0"), "nombre", "id_formulario");
            
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string sql = "Select F.nombre as Formulario,PP.nombre as Perfiles From Permisos P JOIN Formularios F ON P.id_formulario = F.id_formulario JOIN Perfiles PP ON PP.id_perfil = p.id_perfil WHERE F.nombre like @formulario Group By F.nombre,PP.nombre";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            string valor = "TODOS";
            if (ckbForms.Checked)
            {
                parametros.Add("formulario", "%");
                
            }
            else
            {
                parametros.Add("formulario", cboFormularios.Text);
                valor = cboFormularios.Text;
            }
           
            rpvPerfilesXForm.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("formulario",valor)});
            rpvPerfilesXForm.LocalReport.DataSources.Clear();
            rpvPerfilesXForm.LocalReport.DataSources.Add(new ReportDataSource( "DsPerfilesxForm",DataManager.GetInstance().ConsultaSQL(sql,parametros)));
            rpvPerfilesXForm.RefreshReport();
            
        }

        private void frmPerfilesXForm_Load(object sender, EventArgs e)
        {
            this.rpvPerfilesXForm.RefreshReport();
        }

        private void ckbForms_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbForms.Checked)
            {
                cboFormularios.Text = "";
                cboFormularios.Enabled = false;
                
            }
            else 
            {
                cboFormularios.Enabled = true; 
            }
        }
    }
}
