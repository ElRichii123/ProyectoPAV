using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico_PAV_I.Entidades;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmNuevoBug : Form
    {
        public frmNuevoBug()
        {
            InitializeComponent();
            LimpiarCampos();
            CargarGrilla();
            btnActualizarBug.Enabled = false;
        }

        private void btnAgregarBug_Click(object sender, EventArgs e)
        {
            Bug nuevoBug = new Bug();
            nuevoBug.Titulo1 = txtTitulo.Text;
            nuevoBug.Descripcion1 = txtDescripcion.Text;
            nuevoBug.FechaAlta1 = DateTime.Parse(mskFechaAlta.Text);
            nuevoBug.IdUsuarioAsignado1 = (int)cmbUsuarioAsignado.SelectedValue;
            nuevoBug.IdPrioridad1 = (int)cmbPrioridad.SelectedValue;
            nuevoBug.Borrado1 = 0;
            nuevoBug.IdCriticiadad1 = (int)cmbCriticidad.SelectedValue;
            nuevoBug.IdProducto1 = (int)cmbProducto.SelectedValue;
            nuevoBug.IdEstado1 = (int)cmbEstado.SelectedValue;
            nuevoBug.IdUsuarioResponsable1 = 1;

            

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("titulo", txtTitulo.Text.ToString());
            parametros.Add("descripcion", txtDescripcion.Text.ToString());
            
            
            
           
            parametros.Add("id_usuario_responsable", 1);

            if (!string.IsNullOrEmpty(cmbUsuarioAsignado.Text))
            {
                var asignadoA = cmbUsuarioAsignado.SelectedValue.ToString();
                parametros.Add("id_usuario_asignado", asignadoA);
            }
            if (!string.IsNullOrEmpty(cmbProducto.Text))
            {
                var producto = cmbProducto.SelectedValue.ToString();
                parametros.Add("id_producto", producto);
            }
            if (!string.IsNullOrEmpty(cmbPrioridad.Text))
            {
                var prioridad = cmbPrioridad.SelectedValue.ToString();
                parametros.Add("id_prioridad", prioridad);
            }
            if (!string.IsNullOrEmpty(cmbCriticidad.Text))
            {
                var criticidad = cmbCriticidad.SelectedValue.ToString();
                parametros.Add("id_criticidad", criticidad);
            }
            if (!string.IsNullOrEmpty(cmbEstado.Text))
            {
                var idEstado = cmbEstado.SelectedValue.ToString();
                parametros.Add("id_estado", idEstado);
            }
            parametros.Add("borrado", 0);
            try
            {
                string consultaSql = "INSERT INTO Bugs ( titulo, descripcion, fecha_alta, id_usuario_responsable, id_usuario_asignado, id_producto,id_prioridad, id_criticidad, id_estado, borrado) VALUES (@titulo, @descripcion, convert(date,'" + mskFechaAlta.Text + "'), @id_usuario_responsable, @id_usuario_asignado, @id_producto,@id_prioridad, @id_criticidad, @id_estado, @borrado)";
                int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                if(resultado == 0)
                {
                    MessageBox.Show("Error al cargar el Bug.");
                }
                else
                {
                    MessageBox.Show("Carga exitosa del Bug.");
                    CargarGrilla();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                
            }
        }

        

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }
        



        private void CargarGrilla()
        {
            
            try
            { 
                string consulta = "SELECT id_bug, titulo, fecha_alta, id_estado FROM Bugs";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdBugs.DataSource = tabla;

                

                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
        }

        private void frmNuevoBug_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbEstado, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");
            LlenarCombo(cmbPrioridad, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");
            LlenarCombo(cmbCriticidad, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");
            LlenarCombo(cmbUsuarioAsignado, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");
            LlenarCombo(cmbProducto, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
        }

        private void grdBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarBug.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdBugs.Rows[indice];
            string idBug = filaSeleccionada.Cells["Id"].Value.ToString();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            {
                parametros.Add("Id", idBug);
            }
            string consulta = "SELECT * FROM Bugs WHERE id_bug LIKE @Id";
            DataTable tabla = new DataTable();
            tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
            Bug b = new Bug();
            b.Titulo1 = tabla.Rows[0]["titulo"].ToString();
            b.Descripcion1 = tabla.Rows[0]["descripcion"].ToString();
            DateTime fecha = DateTime.Parse(tabla.Rows[0]["fecha_alta"].ToString());
            string fechaSalida = fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES"));
            b.FechaAlta1 = DateTime.Parse(fechaSalida);

            b.IdUsuarioResponsable1 = (int)tabla.Rows[0]["id_usuario_responsable"];
            b.IdUsuarioAsignado1 = (int)tabla.Rows[0]["id_usuario_asignado"];
            b.IdProducto1 = (int)tabla.Rows[0]["id_producto"];
            b.IdPrioridad1 = (int)tabla.Rows[0]["id_prioridad"];
            b.IdCriticiadad1 = (int)tabla.Rows[0]["id_criticidad"];
            b.IdEstado1 = (int)tabla.Rows[0]["id_estado"];
            b.Borrado1 = 0;

            txtTitulo.Text = b.Titulo1;
            txtDescripcion.Text = b.Descripcion1;
            mskFechaAlta.Text = fechaSalida;
            cmbCriticidad.SelectedIndex = b.IdCriticiadad1 - 1;
            cmbPrioridad.SelectedIndex = b.IdPrioridad1 - 1;
            cmbProducto.SelectedIndex = b.IdProducto1 - 1;
            cmbEstado.SelectedIndex = b.IdEstado1 - 1;
            cmbUsuarioAsignado.SelectedIndex = b.IdUsuarioAsignado1 - 1;

        }

        private void btnActualizarBug_Click(object sender, EventArgs e)
        {
            Bug nuevoBug = new Bug();
            nuevoBug.Titulo1 = txtTitulo.Text;
            nuevoBug.Descripcion1 = txtDescripcion.Text;
            nuevoBug.FechaAlta1 = DateTime.Parse(mskFechaAlta.Text);
            nuevoBug.IdUsuarioAsignado1 = (int)cmbUsuarioAsignado.SelectedValue;
            nuevoBug.IdPrioridad1 = (int)cmbPrioridad.SelectedValue;
            nuevoBug.Borrado1 = 0;
            nuevoBug.IdCriticiadad1 = (int)cmbCriticidad.SelectedValue;
            nuevoBug.IdProducto1 = (int)cmbProducto.SelectedValue;
            nuevoBug.IdEstado1 = (int)cmbEstado.SelectedValue;
            nuevoBug.IdUsuarioResponsable1 = 1;

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("titulo", txtTitulo.Text.ToString());
            parametros.Add("descripcion", txtDescripcion.Text.ToString());



            if (!string.IsNullOrEmpty(mskFechaAlta.Text))
            {
                parametros.Add("fecha_alta", mskFechaAlta.Text);

            }
            parametros.Add("id_usuario_responsable", 1);

            if (!string.IsNullOrEmpty(cmbUsuarioAsignado.Text))
            {
                var asignadoA = cmbUsuarioAsignado.SelectedValue.ToString();
                parametros.Add("id_usuario_asignado", asignadoA);
            }
            if (!string.IsNullOrEmpty(cmbProducto.Text))
            {
                var producto = cmbProducto.SelectedValue.ToString();
                parametros.Add("id_producto", producto);
            }
            if (!string.IsNullOrEmpty(cmbPrioridad.Text))
            {
                var prioridad = cmbPrioridad.SelectedValue.ToString();
                parametros.Add("id_prioridad", prioridad);
            }
            if (!string.IsNullOrEmpty(cmbCriticidad.Text))
            {
                var criticidad = cmbCriticidad.SelectedValue.ToString();
                parametros.Add("id_criticidad", criticidad);
            }
            if (!string.IsNullOrEmpty(cmbEstado.Text))
            {
                var idEstado = cmbEstado.SelectedValue.ToString();
                parametros.Add("id_estado", idEstado);
            }
            parametros.Add("borrado", 0);
            
            try
            {
                string consultaSql = "UPDATE Bugs SET descripcion = @descripcion, fecha_alta = @fecha_alta, id_usuario_responsable = @id_usuario_responsable, id_usuario_asignado = @id_usuario_asignado, id_producto = @id_producto, id_prioridad = @id_prioridad, id_criticidad = @id_criticidad, id_estado = @id_estado, borrado = @borrado WHERE titulo = @titulo";
                int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                if (resultado == 0)
                {
                    MessageBox.Show("Error al actualizar el Bug.");
                }
                else
                {
                    MessageBox.Show("Actualizacion exitosa del Bug.");
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");

            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LlenarCombo(cmbEstado, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");
            LlenarCombo(cmbPrioridad, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");
            LlenarCombo(cmbCriticidad, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");
            LlenarCombo(cmbUsuarioAsignado, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");
            LlenarCombo(cmbProducto, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
            btnActualizarBug.Enabled = false;
        }
    }
}
