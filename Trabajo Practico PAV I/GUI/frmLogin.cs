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
        public frmLogin()
        {
            /*padre = principal;*/
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
                        this.Hide();
                        /*padre.tomarUsuario(usu);*/
                        frmPrincipal principal = new frmPrincipal(txtNombreUsuario.Text);
                        principal.ShowDialog();
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
        
        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            bool ingreso = false;
            try 
            {
                
                string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE '"+ nombreDeUsuario+ "'AND password LIKE '"+ password +"'";
                DataTable resultado = DataManager.GetInstance().ConsultaSQL(consulta);
                if(resultado.Rows.Count == 1)
                {
                    ingreso = true;
                }
            }
            catch(SqlException ex)
            {
                //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ingreso;
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
        }

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Mostramos el formulario al centro del formulario padre.
            this.CenterToParent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
