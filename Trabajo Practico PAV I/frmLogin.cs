using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico_PAV_I.Entidades;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmLogin : Form
    {
        private frmPrincipal padre;
        public frmLogin(frmPrincipal principal)
        {
            padre = principal;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtNombreUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Campos vacios. Porfavor introduzca ambos campos.");
            }
            else
            {
                try
                {
                    bool resultado = ValidarUsuario(txtNombreUsuario.Text, txtContraseña.Text);
                    if(resultado)
                    {
                        
                        /*padre.tomarUsuario(usu);*/
                        this.Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña no coinciden.");
                        LimpiarCampos();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                }
            }
        }
        private Usuario getUsuario(string nombreUsuario)
        {
            Usuario usu = new Usuario();
            string consulta = "SELECT * FROM Usuarios WHERE nombre LIKE '" + nombreUsuario + "'";
            DataTable tabla = new DataTable();
            tabla = DataManager.GetInstance().ConsultaSQL(consulta);
            usu.IdUduario = (int)tabla.Rows[0]["id_usuario"];
            usu.IdPerfil = (int)tabla.Rows[0]["id_perfil"];
            usu.NombreUsuario = tabla.Rows[0]["usuario"].ToString();
            usu.Password = tabla.Rows[0]["password"].ToString();
            usu.Email = tabla.Rows[0]["email"].ToString();
            usu.Borrado = (int)tabla.Rows[0]["borrado"];
     
            return usu;
            
            
        }
        private bool ValidarUsuario(string NombreDeUsuario, string Password)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try 
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE @nombreUsu AND password LIKE @pass";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", NombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", Password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                return resultado;
                
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal ventanaPrincipal2 = new frmPrincipal();
            ventanaPrincipal2.Show();
            this.Close();
        }
    }
}
