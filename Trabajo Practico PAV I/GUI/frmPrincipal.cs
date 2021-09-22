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
using Trabajo_Practico_PAV_I.GUI;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuario;
        public frmPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            usuario = ConocerUsuario(nombreUsuario);
            
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
            lblUsuario.Text = usuario.NombreUsuario.ToString();
            lblPerfil.Text = usuario.Perfil;
            if (usuario.IdPerfil != 1)
            {
                menuSoporte.Enabled = false;
            }
            CargarGrilla(usuario);
            this.CenterToParent();
        }

        private void CargarGrilla(Usuario u)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("id_perfil", u.IdPerfil);
                string consulta = "SELECT F.nombre AS 'Nombre' FROM Formularios F JOIN Permisos PP ON F.id_formulario = PP.id_formulario WHERE PP.id_perfil = @id_perfil";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                grdPerfiles.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                frmPrincipal_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }

        }
        private void nuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevoUsuario ventanaNuevoUsuario = new frmNuevoUsuario();
                ventanaNuevoUsuario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        

        
    }

}
