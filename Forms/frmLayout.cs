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
        //private Clases.Conexion objConexionPrincipal;
        private Clases.Conexion objConexion;
        private SqlConnection cone;


        public frmLayout(Clases.Conexion objConexion)
        {
            this.objConexion = objConexion;
            InitializeComponent();
        }
        private void llenarCboxConexiones()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexion.getConexion());
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
        private void llenarCboxSistema()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexion.getConexion());
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
        private void llenarCboxTabla()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexion.getConexion());
            cone.Open();
            //string query = "SELECT t.id,t.descripcion from Tablas t JOIN Consultas c ON c.id_Tabla=t.id JOIN Sistemas s ON s.id=c.id_Sistema where s.id=@id_Sistema  order by t.descripcion";  //                                                                                                    //asigno a comando el sqlcommand
            string query = "SELECT t.id,t.descripcion from Tablas t order by t.descripcion";  //                                                                                                    //asigno a comando el sqlcommand
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
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

        private void llenarCboxConsulta()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexion.getConexion());
            cone.Open();
            //string query = "SELECT t.id,t.descripcion from Tablas t JOIN Consultas c ON c.id_Tabla=t.id JOIN Sistemas s ON s.id=c.id_Sistema where s.id=@id_Sistema  order by t.descripcion";  //                                                                                                    //asigno a comando el sqlcommand
            string query = "SELECT c.id, c.descripcion from Consultas c where c.id_Sistema=@idSistema AND c.id_Tabla=@idTabla order by c.descripcion";  //                                                                                                    //asigno a comando el sqlcommand
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idSistema", cboxSistema.SelectedValue);
            comando.Parameters.AddWithValue("@idTabla", cboxTabla.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            cone.Close();
            DataRow fila = dt.NewRow();
            fila["descripcion"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            this.cboxConsulta.DataSource = dt;
            this.cboxConsulta.ValueMember = "id";
            this.cboxConsulta.DisplayMember = "descripcion";
            cone.Close();

        }

        private String obtenerScriptConsulta(String idConsulta)
        {
            String script="";
            cone = new SqlConnection(objConexion.getConexion());
            string query = "SELECT c.id, c.script from Consultas c where c.id=@idConsulta";
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idConsulta", idConsulta);
            cone.Open();
            SqlDataReader reader =  comando.ExecuteReader();
            if (reader.Read())
            {
                script = reader.GetString(1);//1 por que script posicion1 [id][script]
            }
            cone.Close();
            return script;
        }

        private Boolean puedeLLenarConsultas()
        {
            return cboxSistema.SelectedIndex != 0 && cboxTabla.SelectedIndex != 0;
        }

        private Clases.Conexion obtenerConexionOrigen()
        {
            Clases.Conexion conexionOrigen = null;
            cone = new SqlConnection(objConexion.getConexion());
            string query = "SELECT * from ConexionesOrigen co where co.id=@idConexionOrigen";
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idConexionOrigen", cboxConexion.SelectedValue);
            cone.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())// si hay resultado
            { // se crea el objeto conexion
                conexionOrigen = new Clases.Conexion(reader.GetString(2), reader.GetString(3), reader.GetString(7), reader.GetString(4), reader.GetString(6));
            }
            cone.Close();
            return conexionOrigen;
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            llenarCboxConexiones();
            llenarCboxTabla();


        }

        private void cboxConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxConexion.SelectedIndex != 0)
            {
                llenarCboxSistema();
                if (cboxSistema.Items.Count >= 0)
                {
                    cboxSistema.Enabled = true;
                }
                else
                {
                    cboxSistema.Enabled = false;

                }

            }

        }

        private void cboxSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (puedeLLenarConsultas())
            {
                llenarCboxConsulta();
                cboxConsulta.Enabled = true;
            }
        }

        private void toolEjecutar_Click(object sender, EventArgs e)
        {
            /*
             * CREAR UN CONEXION CON LA INFORMACION DE LA CONEXION ORIGEN
             * OBTENER EL QUERY DEL SISTEMA Y LA TABLA SELECCIOANDO
             * EL SCRIPT SELECCIOANDO PASA A SER EL COMMAND TEXT DEL COMANDO
             * CREAR UN SQLCOMMAND CON LA CONEXION DEL ORIGEN
             * CREAR UN SQLDATAADAPTER Y LE ASIGNAS EL COMANDO
             * CREAR UN DATATABLE
             * LLENAR EL DATA CON EL FILL DEL DATAADAPTER
             * 
              */
            String script = obtenerScriptConsulta(cboxConsulta.SelectedValue.ToString());
            Clases.Conexion conexionOrigen = obtenerConexionOrigen();
            SqlConnection cone = new SqlConnection(conexionOrigen.getConexion());
            cone.Open();
            string query = script;
            SqlCommand comando = new SqlCommand(query, cone);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable sqlDT = new DataTable();
            //lleno el datatable
            da.Fill(sqlDT);
            gridControl1.DataSource = sqlDT;
            cone.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//ventana de guardado
            sfd.Filter = "Archivos de excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToXlsx(sfd.FileName);
                MessageBox.Show("Se guardó el archivo en la ruta:" + sfd.FileName);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (puedeLLenarConsultas())
            {
                llenarCboxConsulta();
                cboxConsulta.Enabled = true;
            }
        }
    }
}
