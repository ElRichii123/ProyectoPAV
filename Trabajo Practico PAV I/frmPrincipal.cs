using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico_PAV_I.Entidades;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuario;
        public frmPrincipal()
        {
            InitializeComponent();
            

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(this);
            login.ShowDialog();
        }
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void nuevoBugToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNuevoBug ventanaNuevoBug = new frmNuevoBug();
            ventanaNuevoBug.Show();
            this.Hide();
        }
        public void tomarUsuario(Usuario usu)
        {
            this.usuario = usu;
            lblUsuario.Text = usuario.NombreUsuario;
        }
    }

}
