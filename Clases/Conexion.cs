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
         public Conexion(string servidor, string instancia, string usuario, string contraseña)
         {
            this.servidor = servidor;
            this.instancia = instancia;
            this.usuario = usuario;
            this.contraseña = contraseña;
                
         }
        public string getConexion()
        {
            string cone = (@"Data Source =" + this.servidor + "; Initial Catalog =" + this.instancia + "; Persist Security Info = True;  User ID =" +this.usuario + "; Password=" + this.contraseña);
            return cone;
        }
  
    }
}
