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
    public partial class frmBusquedaTabla : Form
    {
        public frmBusquedaTabla(Clases.Conexion objConexionPrincipal)
        {
            InitializeComponent();
            this.objConexionPrincipal = objConexionPrincipal;
        }
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;





        public DataTable dt = new DataTable();

        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();

    

       

        public void buscar(string expresion)
        {
            try
            {
                if (!string.IsNullOrEmpty(expresion))//se pone el ! para que devuelva falso y no true
                {
                    cmd.CommandText = "SELECT id, descripcion FROM Tablas WHERE id LIKE '%' + '" + @expresion + "' + '%' OR descripcion LIKE '%' + '" + @expresion + "' + '%'";//sirve para buscar lo que contenga la expresion em id o nombre
                    cmd.Parameters.AddWithValue("@expresion", expresion);
                }
                da.SelectCommand = cmd;//no se ejecute antes
                dgBusquedaT.DataSource = dt;
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

        private void frmBusquedaTabla_Load(object sender, EventArgs e)
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            this.CancelButton = btnCancelar;
            cmd.Connection = cone;
            cmd.CommandText = "SELECT id, descripcion FROM tablas";

            da.SelectCommand = cmd;
            dgBusquedaT.DataSource = dt;
        }

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar(txtExpresion.Text);
            }
        }

        private void txtExpresion_KeyUp(object sender, KeyEventArgs e)
        {
            //cone = new SqlConnection(objConexionPrincipal.getConexion());
            //cone.Open();
            //this.CancelButton = btnCancelar;
            //cmd.Connection = cone;
            //cmd.CommandText = "SELECT * from Tablas where descripcion like ( ' " + txtExpresion.Text + "%')";
            //cmd.ExecuteNonQuery();

            //da.SelectCommand = cmd;
            //dgBusquedaT.DataSource = dt;

            //dt.Clear();
            //da.Fill(dt);
            //dgBusquedaT.DataSource = dt;

            //cone.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
