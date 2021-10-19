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
        }
        private void CargarGrilla()
        {
            try
            {


                string consulta = "Select H.fecha as 'Fecha', F.nombre as 'Nombre Formulario',P.nombre as 'Nombre Perfil' from HistorialPermisos H JOIN Formularios F ON H.id_formulario = F.id_formulario JOIN Perfiles P ON P.id_perfil = H.id_perfil";
                DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
                grdHistorialPermisos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
