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
    public partial class frmBusquedaSistema : Form
    {
        public frmBusquedaSistema(Clases.Conexion objConexionPrincipal)
        {
            InitializeComponent();
            this.objConexionPrincipal = objConexionPrincipal;
        }
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;


        public DataTable dt = new DataTable();
        
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();

        private void frmBusquedaSistema_Load(object sender, EventArgs e)
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            this.CancelButton = btnCancelar;
            cmd.Connection = cone;
            cmd.CommandText = "SELECT id, nombre FROM sistemas";
          
        }

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar(txtExpresion.Text);
            }
        }

        public void buscar(string expresion)
        {
            try
            {
                cmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(expresion))//se pone el ! para que devuelva falso y no true
                {
                    cmd.CommandText = "SELECT id, nombre FROM Sistemas WHERE id LIKE '%' + '" + @expresion + "' + '%' OR nombre LIKE '%' + '" + @expresion + "' + '%'";//sirve para buscar lo que contenga la expresion em id o nombre
                    cmd.Parameters.AddWithValue("@expresion",expresion);
                }
                da.SelectCommand = cmd;//no se ejecute antes
                dgBusqueda.DataSource = dt;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
