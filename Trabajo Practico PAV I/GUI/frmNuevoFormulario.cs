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
    public partial class frmNuevoFormulario : Form
    {
        private Usuario u;
        public frmNuevoFormulario(Usuario usuario)
        {
            InitializeComponent();
            borradoFisicoPermiso();
            u = usuario;
            CargarGrilla();
            LlenarCombo(cmbPerfil, DataManager.GetInstance().ConsultaSQL("select * from Perfiles where borrado = 0 AND nombre NOT LIKE 'Administrador'"), "nombre", "id_perfil");
            LlenarCombo(cmbNombreForm, DataManager.GetInstance().ConsultaSQL("select * from Formularios where borrado = 0"), "nombre", "id_formulario");
        }

        private void frmNuevoFormulario_Load(object sender, EventArgs e)
        {
            
        }
        private void CargarGrilla()
        {
            try
            {
                
                
                string consulta = "Select F.nombre as 'Nombre Formulario',PP.nombre as 'Nombre Perfil' from Permisos P JOIN Formularios F ON P.id_formulario = F.id_formulario JOIN Perfiles PP ON p.id_perfil = PP.id_perfil WHERE P.borrado = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdPermisos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnPermitirAcceso_Click(object sender, EventArgs e)
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(cmbPerfil.Text))
            {

                parametros.Add("id_perfil", (int)cmbPerfil.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(cmbNombreForm.Text))
            {

                parametros.Add("id_formulario", cmbNombreForm.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parametros.Add("borrado", 0);

            String a = fechaYHoraActual();

            parametros.Add("fecha", a);
            try
            {
                string consultaSql = "INSERT INTO Permisos (id_formulario,id_perfil,borrado) VALUES (@id_formulario,@id_perfil,@borrado)";
                int resultado = DataManager.GetInstance().EjecutarSQLTransaccion(consultaSql, parametros);

                string consultaSql2 = "INSERT INTO HistorialPermisos (id_formulario,id_perfil,fecha) VALUES (@id_formulario,@id_perfil,@fecha)";
                int resultado2 = DataManager.GetInstance().EjecutarSQLTransaccion(consultaSql2, parametros);

                if (resultado == 0 || resultado2 == 0)
                {
                    MessageBox.Show("Error al cargar el Permiso.");
                }
                else
                {
                    MessageBox.Show("Carga exitosa del Permiso.");
                    CargarGrilla();
                    
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;

            }
        }
        private String fechaYHoraActual()
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd");
            string datetime = DateTime.Now.ToString("Thh:mm:ss");
            Date = Date + datetime;
            return Date;
        }



        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnRemoverAcceso_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            int indice = -2;
            indice = grdPermisos.CurrentCell.RowIndex;
            if (indice != -2)
            {

                parametros.Add("id_formulario", cmbNombreForm.SelectedValue);
                parametros.Add("id_perfil", cmbPerfil.SelectedValue);
                DialogResult rpta;
                rpta = MessageBox.Show("¿Seguro que desea eliminar el permiso seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DataGridViewRow filaSeleccionada = grdPermisos.Rows[indice];
                    string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                    
                   
                    
                    string consultaSql = "UPDATE Permisos SET borrado = 1  WHERE  id_perfil = @id_perfil AND id_formulario = @id_formulario";
                    int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Error al eliminar el Permiso.");
                    }
                    else
                    {
                        MessageBox.Show("El permiso se elimino correctamente.");
                        CargarGrilla();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Permiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void borradoFisicoPermiso()
        {

            


            string consultaSql = "DELETE FROM Permisos WHERE borrado = 1";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql);
        }
    }
}
