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
    public partial class frmBusquedaConexionesOrigen : Form
    {
        public frmBusquedaConexionesOrigen(Clases.Conexion objConexionPrincipal)
        {
            InitializeComponent();
            this.objConexionPrincipal = objConexionPrincipal;

        }
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;

        public DataTable dt = new DataTable();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();

        private void frmBusquedaConexionesOrigen_Load(object sender, EventArgs e)
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            this.CancelButton = btnCancelar;
            cmd.Connection = cone;
            cmd.CommandText = "SELECT c.id as id,c.id_SistemaC as id_sistema, s.nombre as nombre_sistema,c.servidor,c.instancia,c.contraseña,c.empresaC,c.base_datos,c.usuarioC from ConexionesOrigen c INNER JOIN Sistemas s ON c.id_SistemaC = s.id";

            da.SelectCommand = cmd;
            dgBusquedaConexion.DataSource = dt;
        
            }
        public void buscar(String expresion)
        {
            try
            {
                cmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(expresion))//se pone el ! para que devuelva falso y no true
                {
                    cmd.CommandText = "SELECT c.id as id, c.id_SistemaC as id_sistema, s.nombre as nombre_sistema,c.servidor,c.instancia,c.contraseña,c.empresaC,c.base_datos,c.usuarioC from ConexionesOrigen c INNER JOIN Sistemas s ON c.id_SistemaC = s.id where c.id LIKE '%' + '" + @expresion + "' + '%' OR s.nombre LIKE '%' + '" + @expresion + "' + '%' OR c.servidor LIKE '%' + '" + @expresion + "' + '%' OR c.instancia LIKE '%' + '" + @expresion + "' + '%' OR c.contraseña LIKE '%' + '" + @expresion + "' + '%' OR c.empresaC LIKE '%' + '" + @expresion + "' + '%'  OR c.base_datos LIKE '%' + '" + @expresion + "' + '%'OR c.usuarioC LIKE '%' + '" + @expresion + "' + '%'";
                    cmd.Parameters.AddWithValue("@expresion", expresion);
                }
                da.SelectCommand = cmd;//no se ejecute antes
                dgBusquedaConexion.DataSource = dt;
                dt.Clear();
                da.Fill(dt);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error de base de datos: " + err.Message, "Error busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar(txtExpresion.Text);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
