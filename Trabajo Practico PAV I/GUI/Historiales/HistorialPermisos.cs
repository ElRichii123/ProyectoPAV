using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_PAV_I
{
    public partial class HistorialPermisos : Form
    {
        public HistorialPermisos()
        {
            InitializeComponent();
            CargarGrilla();
            LlenarCombo(cmbBoxPerfil, DataManager.GetInstance().ConsultaSQL("select * from Perfiles where borrado = 0"), "nombre", "id_perfil");
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            cmbBoxPerfil.Enabled = false;
            mskFechaDesde.Enabled = false;
            mskFechaHasta.Enabled = false;
            btnAplicar.Enabled = false;
            btnQuitarFiltro.Enabled = false;
        }
        private void CargarGrilla()
        {
            try
            {


                string consulta = "Select H.fecha as 'Fecha', F.nombre as 'Nombre Formulario',P.nombre as 'Nombre Perfil', H.estado as 'Estado' from HistorialPermisos H JOIN Formularios F ON H.id_formulario = F.id_formulario JOIN Perfiles P ON P.id_perfil = H.id_perfil";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdHistorialPermisos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HistorialPermisos_Load(object sender, EventArgs e)
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

     


        
        


        private void LimpiarCampos()
        {
            mskFechaDesde.Text = "";
            mskFechaHasta.Text = "";
            cmbBoxFiltro.SelectedIndex = -1;
            cmbBoxPerfil.SelectedIndex = -1;
        }

        

        private void cmbBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxFiltro.Text == "Perfil")
            {
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                cmbBoxPerfil.Enabled = true;
                mskFechaDesde.Enabled = false;
                mskFechaHasta.Enabled = false;
                btnAplicar.Enabled = true;
                btnQuitarFiltro.Enabled = true;

            }
            else
            {
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = true;
                cmbBoxPerfil.Enabled = false;
                mskFechaDesde.Enabled = true;
                mskFechaHasta.Enabled = true;
                btnAplicar.Enabled = true;
                btnQuitarFiltro.Enabled = true;
                checkBox1.Checked = false;

            }
        }

        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(cmbBoxPerfil.Text))
                {

                    parametros.Add("id_perfil", (int)cmbBoxPerfil.SelectedValue);
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
                    string consulta = "Select H.fecha as 'Fecha', F.nombre as 'Nombre Formulario',P.nombre as 'Nombre Perfil', H.estado as 'Estado' from HistorialPermisos H JOIN Formularios F ON H.id_formulario = F.id_formulario JOIN Perfiles P ON P.id_perfil = H.id_perfil Where P.id_perfil = @id_perfil AND H.fecha BETWEEN @fechaDesde AND @fechaHasta";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPermisos.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }
            if (cmbBoxFiltro.Text == "Perfil")
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(cmbBoxPerfil.Text))
                {

                    parametros.Add("id_perfil", (int)cmbBoxPerfil.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string consulta = "Select H.fecha as 'Fecha', F.nombre as 'Nombre Formulario',P.nombre as 'Nombre Perfil', H.estado as 'Estado' from HistorialPermisos H JOIN Formularios F ON H.id_formulario = F.id_formulario JOIN Perfiles P ON P.id_perfil = H.id_perfil Where P.id_perfil = @id_perfil";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPermisos.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }
            if(cmbBoxFiltro.Text != "Perfil" && checkBox1.Checked == false)
            {

                Dictionary<string, object> parametros = new Dictionary<string, object>();
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
                    string consulta = "Select H.fecha as 'Fecha', F.nombre as 'Nombre Formulario',P.nombre as 'Nombre Perfil', H.estado as 'Estado' from HistorialPermisos H JOIN Formularios F ON H.id_formulario = F.id_formulario JOIN Perfiles P ON P.id_perfil = H.id_perfil Where H.fecha BETWEEN @fechaDesde AND @fechaHasta";
                    DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                    grdHistorialPermisos.DataSource = tabla;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion con la Base de datos.");
                    throw ex;

                }
            }
        }

        private void btnQuitarFiltro_Click_1(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            cmbBoxPerfil.Enabled = false;
            mskFechaDesde.Enabled = false;
            mskFechaHasta.Enabled = false;
            btnAplicar.Enabled = false;
            btnQuitarFiltro.Enabled = false;
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbBoxFiltro.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                cmbBoxPerfil.Enabled = true;
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
                cmbBoxPerfil.Enabled = false;
                mskFechaDesde.Enabled = false;
                mskFechaHasta.Enabled = false;
                btnAplicar.Enabled = false;
                btnQuitarFiltro.Enabled = false;
            }
        }
    }
}

