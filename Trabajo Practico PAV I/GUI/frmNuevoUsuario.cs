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

namespace Trabajo_Practico_PAV_I.GUI
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
            CargarGrilla();
            borradoFisicoUsuario();
            btnActualizarUsuario.Enabled = false;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre",txtNombreUsuario.Text);
            string consulta = "SELECT usuario as 'Nombre',id_perfil as 'Perfil', password as 'Contraseña', email as 'Email', estado as 'Estado' from Usuarios WHERE usuario LIKE '%"+ txtNombreUsuario.Text+"%'";
            grdUsuarios.DataSource = DataManager.GetInstance().ConsultaSQL(consulta);
            btnActualizarUsuario.Enabled = false;
        }
        private void CargarGrilla()
        {

            try
            {
                string consulta = "SELECT usuario as 'Nombre',id_perfil as 'Perfil', password as 'Contraseña', email as 'Email', estado as 'Estado' from Usuarios WHERE borrado = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdUsuarios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnActualizarUsuario.Enabled = true;
                int indice = e.RowIndex;
                if (indice == -1)
                {
                    return;
                }

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("Nombre", txtNombreUsuario.Text);
                string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE @nombre";
                DataTable tabla = new DataTable();
                tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

                DataGridViewRow filaSeleccionada = grdUsuarios.Rows[indice];
                Usuario u = new Usuario();
                u.NombreUsuario = filaSeleccionada.Cells["Nombre"].Value.ToString();
                u.IdPerfil = (int)filaSeleccionada.Cells["Perfil"].Value;
                u.Email = filaSeleccionada.Cells["Email"].Value.ToString();
                u.Password = filaSeleccionada.Cells["Contraseña"].Value.ToString();
                u.Estado = filaSeleccionada.Cells["Estado"].Value.ToString();


                txtNombreUsuario.Text = u.NombreUsuario;
                txtPassword.Text = u.Password;
                txtEmail.Text = u.Email;
                cboEstado.Text = u.Estado;
                cboPerfiles.Text = u.Perfil;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.NombreUsuario = txtNombreUsuario.Text;
            nuevoUsuario.Password = txtPassword.Text;
            nuevoUsuario.Email = txtEmail.Text;
            nuevoUsuario.IdPerfil = (int)cboPerfiles.SelectedValue;
            nuevoUsuario.Borrado = 0;
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                parametros.Add("usuario", txtNombreUsuario.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un nombre valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                parametros.Add("password", txtPassword.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir una contraseña valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(cboPerfiles.Text))
            {

                parametros.Add("id_perfil", nuevoUsuario.IdPerfil);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                
                parametros.Add("email", txtEmail.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un Email valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(cboEstado.Text))
            {

                parametros.Add("estado", cboEstado.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parametros.Add("borrado", 0);

            try
            {
                string consultaSql = "INSERT INTO Usuarios (id_perfil,usuario,password,email,estado,borrado) VALUES (@id_perfil,@usuario,@password,@email,@estado,@borrado)";
                int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                if (resultado == 0)
                {
                    MessageBox.Show("Error al cargar el Usuario.");
                }
                else
                {
                    MessageBox.Show("Carga exitosa del Usuario.");
                    CargarGrilla();
                    btnActualizarUsuario.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;

            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            int indice = grdUsuarios.CurrentCell.RowIndex;
            DataGridViewRow filaSeleccionada = grdUsuarios.Rows[indice];
            string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
            string consultaId = "select id_usuario from Usuarios where usuario  = '" + nombre + "'";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
            
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            int id = (int)rtdo.Rows[0]["id_usuario"];
            parametros.Add("id", id);

            Usuario usuario = new Usuario();
            usuario.Borrado = 0;

            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                usuario.NombreUsuario = nombre;
                parametros.Add("nombre", usuario.NombreUsuario);
            }
            else
            {
                MessageBox.Show("Debe escribir un nombre valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                usuario.Password = txtPassword.Text.ToString();
                parametros.Add("password", txtPassword.Text.ToString()); 
            }
            else
            {
                MessageBox.Show("Debe escribir una contraseña valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                usuario.Email = txtEmail.Text.ToString();
                parametros.Add("email", usuario.Email);
            }
            else
            {
                MessageBox.Show("Debe escribir un email valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(cboPerfiles.Text))
            {
                usuario.IdPerfil = usuario.ObtenerIdPerfil(cboPerfiles.Text.ToString());
                parametros.Add("id_perfil", usuario.IdPerfil);
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(cboEstado.Text))
            {
                usuario.Estado = cboEstado.Text.ToString();
                parametros.Add("estado", usuario.Estado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string consultaSql = "UPDATE Usuarios SET usuario = @nombre, password = @password, email = @email, id_perfil = @id_perfil, estado = @estado WHERE  id_usuario = @id";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
            if (resultado == 0)
            {
                MessageBox.Show("Error al actualizar el Usuario.");
            }
            else
            {
                MessageBox.Show("Actualizacion exitosa del Usuario.");
                btnActualizarUsuario.Enabled = false;
                frmNuevoUsuario_Load(sender, e);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            int indice = -2;
            indice = grdUsuarios.CurrentCell.RowIndex;
            if (indice != -2)
            {
                var idEstado = txtNombreUsuario.ToString();
                parametros.Add("usuario", txtNombreUsuario.Text.ToString());
                DialogResult rpta;
                rpta = MessageBox.Show("¿Seguro que desea eliminar el usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DataGridViewRow filaSeleccionada = grdUsuarios.Rows[indice];
                    string usuario = filaSeleccionada.Cells["Nombre"].Value.ToString();

                    string consultaId = "select id_usuario from Usuarios where usuario = '" + usuario + "' AND borrado = 0";
                    DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
                    int id = (int)rtdo.Rows[0]["id_usuario"];
                    parametros.Add("id", id);
                    string consultaSql = "UPDATE Usuarios SET borrado = 1  WHERE  id_usuario = @id";
                    int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Error al eliminar el Usuario.");
                    }
                    else
                    {
                        MessageBox.Show("El usuario se elimino correctamente.");
                        CargarGrilla();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
        private void borradoFisicoUsuario()
        {

            string consultaId = "select id_usuario from Usuarios WHERE borrado  = 1";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);


            string consultaSql = "DELETE FROM Usuarios WHERE borrado = 1";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql);
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfiles, DataManager.GetInstance().ConsultaSQL("select * from Perfiles"), "nombre", "id_perfil");
            cboEstado.Items.Add("activo");
            cboEstado.Items.Add("inactivo");
            txtNombreUsuario.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            cboEstado.Text = "";
            cboPerfiles.Text = "";
            CargarGrilla();
        }

        

        
    }
}
