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
    
    public partial class frmFormsAcces : Form
    {
        public Usuario usuario;
        public frmFormsAcces(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void frmFormsAcces_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("id_perfil", usuario.IdPerfil);
                string consulta = "SELECT F.nombre AS 'Nombre' FROM Formularios F JOIN Permisos PP ON F.id_formulario = PP.id_formulario WHERE PP.id_perfil = @id_perfil AND F.borrado = 0";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
                dgvFormularios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
