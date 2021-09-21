
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_PAV_I.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
        }
        public int IdUduario {get; set;}
        public int IdPerfil {get; set;}
        public string NombreUsuario {get; set;}
        public string Password {get; set;}
        public string Email {get; set;}
        public int Borrado {get; set; }
        public string Perfil
        {
            get
            {
            string consulta = "Select nombre from perfiles p join usuarios u ON p.id_perfil = u.id_perfil WHERE u.id_perfil = '" + IdPerfil +"'";
            DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta);
            return tabla.Rows[0]["nombre"].ToString();
            }
        }
        public int ObtenerIdPerfil(string perfil)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("perfil", perfil);
            string consulta = "Select id_perfil from Perfiles where nombre = @perfil";
            DataTable tabla = DataManager.GetInstance().ConsultaSQL(consulta, parametros);
            return (int)tabla.Rows[0]["id_perfil"];
        }
        
    }
}
