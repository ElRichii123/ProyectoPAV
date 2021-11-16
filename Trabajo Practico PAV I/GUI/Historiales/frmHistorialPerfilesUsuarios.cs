using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_PAV_I.GUI
{
    public partial class frmHistorialPerfilesUsuarios : Form
    {
        public frmHistorialPerfilesUsuarios()
        {
            
            InitializeComponent();
            CargarGrilla();
            LlenarCombo(cmbBoxUsuario, DataManager.GetInstance().ConsultaSQL("select * from Usuarios where borrado = 0"), "usuario", "id_usuario");
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            cmbBoxUsuario.Enabled = false;
            mskFechaDesde.Enabled = false;
            mskFechaHasta.Enabled = false;
            btnAplicar.Enabled = false;
            btnQuitarFiltro.Enabled = false;
            checkBox1.Checked = false;

        }

        private void CargarGrilla()
        {
            try
            {

                string consulta = "SELECT U.usuario as 'Usuario', P.nombre as 'Perfil', H.fecha as 'Fecha' FROM HistorialPerfilesUsuarios H JOIN Usuarios U ON h.id_usuario = U.id_usuario JOIN Perfiles P ON P.id_perfil = h.id_perfil";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdHistorialPerfilesUsuarios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmHistorialPerfilesUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(cmbBoxUsuario.Text))
                {

                    parametros.Add("id_usuario", (int)cmbBoxUsuario.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(mskFechaDesde.Text))
                {

                    parametros.Add("fechaDesde", DateTime.Parse(mskFechaDesde.Text));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!string.IsNullOrEmpty(mskFechaHasta.Text))
                {

                    parametros.Add("fechaHasta", DateTime.Parse(mskFechaHasta.Text));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha de fin", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string consulta = "SELECT U.usuario as 'Usuario', P.nombre as 'Perfil', H.fecha as 'Fecha' FROM HistorialPerfilesUsuarios H JOIN Usuarios U ON h.id_usuario = U.id_usuario JOIN Perfiles P ON P.id_perfil = h.id_perfil WHERE (H.fecha BETWEEN @fechaDesde AND @fechaHasta) AND U.id_usuario = @id_usuario";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPerfilesUsuarios.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }
            if (cmbBoxFiltro.Text == "Usuario")
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(cmbBoxUsuario.Text))
                {

                    parametros.Add("id_usuario", (int)cmbBoxUsuario.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string consulta = "SELECT U.usuario as 'Usuario', P.nombre as 'Perfil', H.fecha as 'Fecha' FROM HistorialPerfilesUsuarios H JOIN Usuarios U ON h.id_usuario = U.id_usuario JOIN Perfiles P ON P.id_perfil = h.id_perfil WHERE U.id_usuario = @id_usuario";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPerfilesUsuarios.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }
            if (cmbBoxFiltro.Text != "Usuario" && checkBox1.Checked == false)
            {
                
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(mskFechaDesde.Text))
                {

                    parametros.Add("fechaDesde",DateTime.Parse(mskFechaDesde.Text));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!string.IsNullOrEmpty(mskFechaHasta.Text))
                {

                    parametros.Add("fechaHasta", DateTime.Parse(mskFechaHasta.Text));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha de fin", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string consulta = "SELECT U.usuario as 'Usuario', P.nombre as 'Perfil', H.fecha as 'Fecha' FROM HistorialPerfilesUsuarios H JOIN Usuarios U ON h.id_usuario = U.id_usuario JOIN Perfiles P ON P.id_perfil = h.id_perfil WHERE H.fecha BETWEEN @fechaDesde AND @fechaHasta";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPerfilesUsuarios.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }

        }
        

        private void cmbBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxFiltro.Text == "Usuario")
            {
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                cmbBoxUsuario.Enabled = true;
                mskFechaDesde.Enabled = false;
                mskFechaHasta.Enabled = false;
                btnAplicar.Enabled = true;
                btnQuitarFiltro.Enabled = true;

            }
            else {
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = true;
                cmbBoxUsuario.Enabled = false;
                mskFechaDesde.Enabled = true;
                mskFechaHasta.Enabled = true;
                btnAplicar.Enabled = true;
                btnQuitarFiltro.Enabled = true;
                

            }
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            cmbBoxUsuario.Enabled = false;
            mskFechaDesde.Enabled = false;
            mskFechaHasta.Enabled = false;
            btnAplicar.Enabled = false;
            btnQuitarFiltro.Enabled = false;
            checkBox1.Checked = false;
        }
        private void LimpiarCampos()
        {
            mskFechaDesde.Text = "";
            mskFechaHasta.Text = "";
            cmbBoxFiltro.SelectedIndex = -1;
            cmbBoxUsuario.SelectedIndex = -1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbBoxFiltro.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                cmbBoxUsuario.Enabled = true;
                mskFechaDesde.Enabled = true;
                mskFechaHasta.Enabled = true;
                btnAplicar.Enabled = true;
                btnQuitarFiltro.Enabled = true;
            }
            else
            {
                cmbBoxFiltro.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                cmbBoxUsuario.Enabled = false;
                mskFechaDesde.Enabled = false;
                mskFechaHasta.Enabled = false;
                btnAplicar.Enabled = false;
                btnQuitarFiltro.Enabled = false;
            }
        }
    }
}
