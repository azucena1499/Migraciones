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
            cmd.CommandText = "SELECT id,id_Sistema,id_Tabla,descripcion,script FROM Consultas";
            da.SelectCommand = cmd;
            dgBusquedaConsulta.DataSource = dt;
        }
        public void buscar(String expresion)
        {
            try
            {
                cmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(expresion))//se pone el ! para que devuelva falso y no true
                {
                    cmd.CommandText = "SELECT id,id_Sistema,id_Tabla,descripcion,script from Consultas where id LIKE '%' + '" + @expresion + "' + '%' OR id_Sistema LIKE '%' + '" + @expresion + "' + '%' OR id_Tabla LIKE '%' + '" + @expresion + "' + '%' OR descripcion LIKE '%' + '" + @expresion + "' + '%' OR script LIKE '%' + '" + @expresion + "' + '%'";

                    //cmd.CommandText = "SELECT id, nombre FROM Sistemas WHERE id LIKE '%' + '" + @expresion + "' + '%' OR nombre LIKE '%' + '" + @expresion + "' + '%'";//sirve para buscar lo que contenga la expresion em id o nombre
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
    }
}
