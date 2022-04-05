using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migraciones.Forms
{
    public partial class frmLayout : Form
    {
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;
        public frmLayout(Clases.Conexion objConexionPrincipal)
        {
            this.objConexionPrincipal = objConexionPrincipal;
            InitializeComponent();
        }
        private void llenarcboxConexiones()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT * from ConexionesOrigen where id >=1";
            //defino comando
            SqlCommand comando = new SqlCommand(query, cone);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            cone.Close();
            DataRow fila = dt.NewRow();
            fila["base_datos"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            this.cboxConexion.DataSource = dt;
            this.cboxConexion.ValueMember = "id";
            this.cboxConexion.DisplayMember = "base_datos";
            cone.Close();
        }
        private void llenarcboxSistema()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT * from Sistemas s JOIN ConexionesOrigen co ON s.id=co.id_SistemaC where co.id=@idConexion  order by s.nombre";  //                                                                                                    //asigno a comando el sqlcommand
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idConexion", cboxConexion.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            cone.Close();
            DataRow fila = dt.NewRow();
            fila["nombre"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            this.cboxSistema.DataSource = dt;
            this.cboxSistema.ValueMember = "id";
            this.cboxSistema.DisplayMember = "nombre";
            cone.Close();
        }
        private void llenarcboxTabla()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT t.id,t.descripcion from Tablas t JOIN Consultas c ON c.id_Tabla=t.id JOIN Sistemas s ON s.id=c.id_Sistema where s.id=@id_Sistema  order by t.descripcion";  //                                                                                                    //asigno a comando el sqlcommand
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id_Sistema", cboxSistema.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            cone.Close();
            DataRow fila = dt.NewRow();
            fila["descripcion"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            this.cboxTabla.DataSource = dt;
            this.cboxTabla.ValueMember = "id";
            this.cboxTabla.DisplayMember = "descripcion";
            cone.Close();
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            llenarcboxConexiones();
        }

        private void cboxConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxConexion.SelectedIndex != 0)
            {
                llenarcboxSistema();
                if (cboxSistema.Items.Count >= 0)
                {
                    cboxSistema.Enabled = true;
                }
                else
                {
                    cboxSistema.Enabled = false;

                }
                cboxTabla.SelectedIndex = 0;
                cboxTabla.Enabled = false;

            }

        }

        private void cboxSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSistema.SelectedIndex != 0)
            {
                llenarcboxTabla();
                if (cboxTabla.Items.Count >= 0)
                {
                    cboxTabla.Enabled = true;
                }
                else
                {
                    cboxTabla.Enabled = false;

                }
               
            }
        }
    }
}
