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
        public frmPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            Usuario usuario = ConocerUsuario(nombreUsuario);
            lblUsuario.Text = usuario.NombreUsuario.ToString();
            lblPerfil.Text = usuario.Perfil;
        }
        private Usuario ConocerUsuario(string nombreUsuario)
        {
            Usuario usu = new Usuario();
            string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE '" + nombreUsuario + "'";
            DataTable tabla = new DataTable();
            tabla = DataManager.GetInstance().ConsultaSQL(consulta);
            usu.IdUduario = (int)tabla.Rows[0]["id_usuario"];
            usu.IdPerfil = (int)tabla.Rows[0]["id_perfil"];
            usu.NombreUsuario = tabla.Rows[0]["usuario"].ToString();
            usu.Password = tabla.Rows[0]["password"].ToString();
            usu.Email = tabla.Rows[0]["email"].ToString();
            /*usu.Borrado = (int)tabla.Rows[0]["borrado"]; Genera un error lo demas funciona gucci*/
            return usu;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            this.CenterToParent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void nuevoPerfil_Click(object sender, EventArgs e)
        {
            try
            {
            frmNuevoPerfil ventanaNuevoPerfil = new frmNuevoPerfil();
            ventanaNuevoPerfil.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
            }

        }
        private void modificarPerfil_Click(object sender, EventArgs e)
        {

        }

        private void consultarPerfil_Click(object sender, EventArgs e)
        {

        }

        private void eliminarPerfil_Click(object sender, EventArgs e)
        {

        }

        
    }

}
