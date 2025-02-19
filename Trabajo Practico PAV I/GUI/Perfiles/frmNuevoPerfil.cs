﻿using System;
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
using Trabajo_Practico_PAV_I.GUI;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmNuevoPerfil : Form
    {
        public frmNuevoPerfil()
        {
            InitializeComponent();
            CargarGrilla();
            borradoFisicoPerfil();
            btnActualizarBug.Enabled = false;
            
        }

        private void CargarGrilla()
        {
            
            try
            { 
                string consulta = "select nombre as 'Nombre' from Perfiles WHERE borrado = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdPerfiles.DataSource = tabla;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                btnActualizarBug.Enabled = true;
                int indice = e.RowIndex;
                if (indice == -1)
                {
                    return;
                }
                DataGridViewRow filaSeleccionada = grdPerfiles.Rows[indice];
                
                
                Perfil p = new Perfil();
                p.NombrePerfil = filaSeleccionada.Cells["Nombre"].Value.ToString();
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                string consulta = " select id_perfil from Perfiles where nombre = @nombre";
                parametros.Add("nombre", p.NombrePerfil);
                DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                
                /*if ((int)rtdo.Rows[0]["id_perfil"] == 1)
                {
                    btnActualizarBug.Enabled = false;
                    btnConsultarPerfil.Enabled = false;
                    btnEliminarPerfil.Enabled = false;
                    btnAgregarBug.Enabled = false;
                    return;
                }*/
                
                txtNombre.Text = p.NombrePerfil;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
            }
            
        }
        private void btnAgregarBug_Click(object sender, EventArgs e)
        {
            Perfil nuevoPerfil = new Perfil();
            nuevoPerfil.NombrePerfil = txtNombre.Text;
            nuevoPerfil.Borrado = 0;
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var idEstado = txtNombre.ToString();
                parametros.Add("nombre", txtNombre.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un titulo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            parametros.Add("borrado", 0);
            try
            {
                string consultaSql = "INSERT INTO Perfiles (nombre,borrado) VALUES (@nombre,@borrado)";
                int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                if(resultado == 0)
                {
                    MessageBox.Show("Error al cargar el Perfil.");
                }
                else
                {
                    MessageBox.Show("Carga exitosa del Perfil.");
                    CargarGrilla();
                    btnActualizarBug.Enabled = false;
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                
            }
            
        }

        private void btnActualizarBug_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var idEstado = txtNombre.ToString();
                parametros.Add("nombre", txtNombre.Text.ToString());
            }
            else
            {
                MessageBox.Show("Debe escribir un titulo valido","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            int indice = grdPerfiles.CurrentCell.RowIndex;
            DataGridViewRow filaSeleccionada = grdPerfiles.Rows[indice];
            string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
            
            string consultaId = "select id_perfil from Perfiles where nombre  = '"+nombre +"'";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
            int id = (int)rtdo.Rows[0]["id_perfil"];
            parametros.Add("id", id);
            string consultaSql = "UPDATE Perfiles SET nombre = @nombre  WHERE  id_perfil = @id";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
            if (resultado == 0)
            {
                    MessageBox.Show("Error al actualizar el Perfil.");
            }
            else
            {
                MessageBox.Show("Actualizacion exitosa del Perfil.");
                btnActualizarBug.Enabled = false;
                CargarGrilla();
            }
            
            
        }

        private void btnConsultarPerfil_Click(object sender, EventArgs e)
        {
            string  consulta = "SELECT nombre AS Nombre FROM Perfiles WHERE nombre LIKE '%"+ txtNombre.Text +"%'";
            /*Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("Nombre",txtNombre.Text);*/
            grdPerfiles.DataSource = DataManager.GetInstance().ConsultaSQL(consulta);
            btnActualizarBug.Enabled = false;
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            
            int indice = -2;
            indice = grdPerfiles.CurrentCell.RowIndex;
            if (indice != -2)
            {
                
                parametros.Add("nombre", txtNombre.Text.ToString());
                DialogResult rpta;
                rpta = MessageBox.Show("¿Seguro que desea eliminar el perfil seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DataGridViewRow filaSeleccionada = grdPerfiles.Rows[indice];
                    string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                    bool perfilUsado = ValidarPerfil(nombre);
                    if (perfilUsado)
                    {
                        MessageBox.Show("El perfil que desea eliminar es utilizado por al menos un usuario, elimine el/los usuario o modifique su/s perfil/es", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmNuevoUsuario ventanaUsu = new frmNuevoUsuario();
                        ventanaUsu.ShowDialog();
                        return;
                    }
                    
                    
                    string consultaId = "select id_perfil from Perfiles where nombre  = '" + nombre + "' AND borrado = 0";
                    DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
                    int id = (int)rtdo.Rows[0]["id_perfil"];
                    parametros.Add("id", id);
                    string consultaSql = "UPDATE Perfiles SET borrado = 1  WHERE  id_perfil = @id";
                    int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql, parametros);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Error al eliminar el Perfil.");
                    }
                    else
                    {
                        MessageBox.Show("El perfil se elimino correctamente.");
                        CargarGrilla();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }
        private void borradoFisicoPerfil()
        {
            
            string consultaId = "select id_perfil from Perfiles WHERE borrado  = 1";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId);
            
            
            string consultaSql = "DELETE FROM Perfiles WHERE borrado = 1";
            int resultado = DataManager.GetInstance().EjecutarSQL(consultaSql);
        }

        private bool ValidarPerfil(string nombrePerfil)
        {
            bool resultado = false;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombrePerfil);
            string consultaId = "select nombre from Perfiles P JOIN Usuarios U ON P.id_perfil = U.id_perfil WHERE P.nombre = @nombre";
            DataTable rtdo = DataManager.GetInstance().ConsultaSQL(consultaId,parametros);
            if (rtdo.Rows.Count >= 1)
            {
                /*Al menos un usuario usa ese perfil*/
                resultado = true;
            }
            return resultado;
        }
    }   
    
}
