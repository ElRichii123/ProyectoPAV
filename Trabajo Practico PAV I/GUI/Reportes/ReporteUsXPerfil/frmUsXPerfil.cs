using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil
{
    public partial class frmUsXPerfil : Form
    {
        public frmUsXPerfil()
        {
            InitializeComponent();
        }

        private void frmUsXPerfil_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'DsUsXPerfil.dtblUsXPerfil' Puede moverla o quitarla según sea necesario.
            this.dtblUsXPerfilTableAdapter.Fill(this.DsUsXPerfil.dtblUsXPerfil);
            this.reportViewer1.RefreshReport();
        }
    }
}
