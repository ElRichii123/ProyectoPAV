﻿using System;
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
using Trabajo_Practico_PAV_I.GUI.Reportes.ReportePerfilesXForm;
using Trabajo_Practico_PAV_I.GUI.Reportes.ReporteUsXPerfil;

namespace Trabajo_Practico_PAV_I
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuario;
        public frmPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            hideSubMenu();
            usuario = ConocerUsuario(nombreUsuario);
            
        }

        private void hideSubMenu()
        {
            pnlSubMenuAdministrar.Visible = false;
            pnlSubMenuOperaciones.Visible = false;
            pnlSubMenuReportes.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Button MenuUsado = null;
        private void btnAdministrar_Click(object sender, EventArgs e)
        {
           
            if (MenuUsado != null)
            {
                MenuUsado.BackColor = SystemColors.Control;
                
            }
            btnAdministrar.BackColor = Color.Gray;
            MenuUsado = btnAdministrar;
            showSubMenu(pnlSubMenuAdministrar);
        }
        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            if (MenuUsado != null)
            {
                MenuUsado.BackColor = SystemColors.Control;
            }
            btnOperaciones.BackColor = Color.Gray;
            MenuUsado = btnOperaciones;
            showSubMenu(pnlSubMenuOperaciones);
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (MenuUsado != null)
            {
                MenuUsado.BackColor = SystemColors.Control;
            }
            btnReportes.BackColor = Color.Gray;
            MenuUsado = btnReportes;
            showSubMenu(pnlSubMenuReportes);
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
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
            openChildFormInPanel(new frmFormsAcces(usuario));

            if (usuario.IdPerfil != 1)
            {
               btnAdministrar.Enabled = false;
            }
            
            this.CenterToParent();
        }

        /*private void CargarGrilla(Usuario u)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("id_perfil", u.IdPerfil);
                string consulta = "SELECT F.nombre AS 'Nombre' FROM Formularios F JOIN Permisos PP ON F.id_formulario = PP.id_formulario WHERE PP.id_perfil = @id_perfil AND F.borrado = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                grdPerfiles.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
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
                
                openChildFormInPanel(new frmNuevoPerfil());
                
                /*frmNuevoPerfil ventanaNuevoPerfil = new frmNuevoPerfil();
                ventanaNuevoPerfil.ShowDialog();
                frmPrincipal_Load(sender, e);*/
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
                openChildFormInPanel(new frmNuevoUsuario());
                /*btnUsuarios.BackColor = Color.Silver;
                frmNuevoUsuario ventanaNuevoUsuario = new frmNuevoUsuario();
                ventanaNuevoUsuario.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        private void nuevoFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                openChildFormInPanel(new frmNuevoFormulario(usuario));
                /*btnFormularios.BackColor = Color.Silver;*/
                /*frmNuevoFormulario ventanaNuevoFormulario = new frmNuevoFormulario(usuario);
                ventanaNuevoFormulario.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        private void historialPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openChildFormInPanel(new HistorialPermisos());
               /*btnHistorialFormularios.BackColor = Color.Silver;*/
                /*HistorialPermisos ventanaHistorialPermisos = new HistorialPermisos();
                ventanaHistorialPermisos.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        private void historialPerfilesDelUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openChildFormInPanel(new frmHistorialPerfilesUsuarios());
                /*btnHistorialPerfiles.BackColor = Color.Silver;*/
                /*frmHistorialPerfilesUsuarios ventanaHistorialPerfilesUsuarios = new frmHistorialPerfilesUsuarios();
                ventanaHistorialPerfilesUsuarios.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        

        private void usuariosPorPerfilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                openChildFormInPanel(new frmUsXPerfil());
                /*btnUsXPerfil.BackColor = Color.Silver;*/
                /*frmUsXPerfil ventanaReporte = new frmUsXPerfil();
                ventanaReporte.ShowDialog();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (MenuUsado != null)
            {
                MenuUsado.BackColor = SystemColors.Control;
            }
            hideSubMenu();
            frmPrincipal_Load(sender, e);
        }

        private void btnPerfilesXFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                openChildFormInPanel(new frmPerfilesXForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la Base de datos.");
                throw ex;
            }
        }
    }

}
