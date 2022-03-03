using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraciones.Clases
{
    class Conexion
    {
        public string Conn(string servidor, string instancia, string usuario, string contraseña)

        {
            string cone = (@"Data Source =" + servidor + "; Initial Catalog =" + instancia + "; Persist Security Info = True;  User ID =" + usuario + "; Password=" + contraseña);
            return cone;
        }
  
    }
}
