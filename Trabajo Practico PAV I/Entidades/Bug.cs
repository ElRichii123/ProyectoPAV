using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_PAV_I.Entidades
{
    public class Bug
    {
        private string Titulo;
        private string Descripcion;
        private DateTime FechaAlta;
        private int IdUsuarioResponsable;
        private int IdUsuarioAsignado;
        private int IdProducto;
        private int IdPrioridad;
        private int IdCriticiadad;
        private int IdEstado;
        private int Borrado;

        public Bug()
        {
        }

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public DateTime FechaAlta1 { get => FechaAlta; set => FechaAlta = value; }
        public int IdUsuarioResponsable1 { get => IdUsuarioResponsable; set => IdUsuarioResponsable = value; }
        public int IdUsuarioAsignado1 { get => IdUsuarioAsignado; set => IdUsuarioAsignado = value; }
        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public int IdPrioridad1 { get => IdPrioridad; set => IdPrioridad = value; }
        public int IdCriticiadad1 { get => IdCriticiadad; set => IdCriticiadad = value; }
        public int IdEstado1 { get => IdEstado; set => IdEstado = value; }
        public int Borrado1 { get => Borrado; set => Borrado = value; }
    }
}
