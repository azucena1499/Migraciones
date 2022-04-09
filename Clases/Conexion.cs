using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraciones.Clases
{
    public class Conexion
    {
        private string servidor;
        private string instancia;
        private string usuario;
        private string contraseña;
        private string baseDatos;
         public Conexion(string servidor, string instancia, string usuario, string contraseña,string baseDatos)
         {
            this.servidor = servidor;
            this.instancia = instancia;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.baseDatos = baseDatos;
                
         }
        public string getConexion()
        {
            string serverInstancia = "";
            if (!string.IsNullOrEmpty(this.instancia))
            {
                serverInstancia=(@"\") + serverInstancia;
            }
            string cone = (@"Server=" + this.servidor + serverInstancia + "; Database=" + this.baseDatos + "; Persist Security Info = True;  User ID =" +this.usuario + "; Password=" + this.contraseña);
            return cone;
        }
  
    }
}
