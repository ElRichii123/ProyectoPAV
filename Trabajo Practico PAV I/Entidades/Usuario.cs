using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_PAV_I.Entidades
{
    public class Usuario
    {
        private static Usuario datos;


        public Usuario()
        {
        }
        public static Usuario Instance()
        {
            if (datos == null)
            {
                datos = new Usuario();
            }
            return datos;
        }

        public int IdUduario {get; set;}
        public int IdPerfil {get; set;}
        public string NombreUsuario {get; set;}
        public string Password {get; set;}
        public string Email {get; set;}
        public int Borrado {get; set;}
    }
}
