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
        }

        private void CargarGrilla()
        {
            try
            {


                string consulta = "SELECT U.usuario as 'Ususario', P.nombre as 'Perfil', H.fecha as 'Fecha' FROM HistorialPerfilesUsuarios H JOIN Usuarios U ON h.id_usuario = U.id_usuario JOIN Perfiles P ON P.id_perfil = U.id_perfil";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdHistorialPerfilesUsuarios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
