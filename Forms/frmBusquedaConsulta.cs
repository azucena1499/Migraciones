using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Migraciones.Forms
{
    public partial class frmBusquedaConsulta : Form
    {
        public frmBusquedaConsulta(Clases.Conexion objConexionPrincipal)
        {
            InitializeComponent();
            this.objConexionPrincipal = objConexionPrincipal;

        }
        
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;

        public DataTable dt = new DataTable();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();

        private void frmBusquedaConsulta_Load(object sender, EventArgs e)
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            this.CancelButton = btnCancelar;
            cmd.Connection = cone;
            cmd.CommandText = "SELECT c.id as id,s.nombre as nombre_sistema,t.descripcion as nombre_tabla,c.descripcion as nombre_consulta,c.script,c.id_sistema,c.id_tabla FROM Consultas c INNER JOIN Sistemas s ON c.id_Sistema = s.id INNER JOIN Tablas t ON c.id_tabla = t.id ";
            da.SelectCommand = cmd;
            dgBusquedaConsulta.DataSource = dt;
            llenarcboxSistema();
        }
        private void llenarcboxSistema()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT * from Sistemas where id >=1 order by nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, cone);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            cone.Close();
            DataRow fila = dt.NewRow();
            fila["nombre"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            this.cboxsistema1.DataSource = dt;
            this.cboxsistema1.ValueMember = "id";
            this.cboxsistema1.DisplayMember = "nombre";
            cone.Close();
        }

        public void buscar(String expresion)
        {
            try
            {
                cmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(expresion))//se pone el ! para que devuelva falso y no true
                {
                    cmd.CommandText = "SELECT c.id as id,s.nombre as nombre_sistema,t.descripcion as nombre_tabla,c.descripcion as nombre_consulta,c.script,c.id_sistema,c.id_tabla FROM Consultas c INNER JOIN Sistemas s ON c.id_Sistema = s.id INNER JOIN Tablas t ON c.id_tabla = t.id where c.id LIKE '%' + '" + @expresion + "' + '%' OR s.nombre LIKE '%' + '" + @expresion + "' + '%' OR t.descripcion LIKE '%' + '" + @expresion + "' + '%' OR c.descripcion LIKE '%' + '" + @expresion + "' + '%' OR c.script LIKE '%' + '" + @expresion + "' + '%'";
                    //cmd.CommandText = "SELECT c.id,  p.nombre,c.descripcion,c.script, r.descripcion FROM Consultas c INNER JOIN Sistemas p ON c.id_Sistema= p.id INNER JOIN Tablas r ON r.id =p.id where id LIKE '%' + '" + @expresion + "' + '%' OR p.id_Sistema LIKE '%' + '" + @expresion + "' + '%' OR c.id_Tabla LIKE '%' + '" + @expresion + "' + '%' OR c.descripcion LIKE '%' + '" + @expresion + "' + '%' OR c.script LIKE '%' + '" + @expresion + "' + '%'";
                    cmd.Parameters.AddWithValue("@expresion", expresion);
                }
                da.SelectCommand = cmd;//no se ejecute antes
                dgBusquedaConsulta.DataSource = dt;
                dt.Clear();
                da.Fill(dt);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error de base de datos: " + err.Message, "Error busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

     
        private void cboxsistema1_SelectedValueChanged(object sender, EventArgs e)
        {
            buscar(cboxsistema1.Text);

        }
    }
}
