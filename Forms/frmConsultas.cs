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
    public partial class frmConsultas : Form
    {
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;
        private int existe = 0;

        public frmConsultas(Clases.Conexion objConexionPrincipal)
        {
            this.objConexionPrincipal = objConexionPrincipal;
            InitializeComponent();
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
            string query = "SELECT * from Tablas where id >=1 order by descripcion";
            //defino comando
            SqlCommand comando = new SqlCommand(query, cone);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
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
        private void maximo()
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT max(id)+1 as ultimo from Consultas";
            SqlCommand comando = new SqlCommand(query, cone);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtClave.Text = leer["ultimo"].ToString();
                if (txtClave.Text == "")
                {
                    txtClave.Text = "1";
                }   
            }
            
            
            
        }
        private void limpiar()
        {
            txtDescripcion.Clear();
            txtClave.Clear();
            txtConsulta.Focus();
            cboxSistema.ResetText();
            cboxTabla.ResetText();
            Tbtneliminar.Enabled = false;
        }
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            llenarcboxSistema();
            llenarcboxTabla();
            maximo();

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0:
                    if (existe == 0)
                    {
                        cone = new SqlConnection(objConexionPrincipal.getConexion());
                        //se abre la conexion
                        cone.Open();
                        string query = "insert into Consultas values(@id_Sistema,@id_Tabla,@descripcion,@script)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                        SqlCommand comando = new SqlCommand(query, cone);
                        comando.Parameters.Clear();
                        //comando.Parameters.AddWithValue("@id", txtClave.Text); //este es para ya modificar 
                        comando.Parameters.AddWithValue("@id_Sistema",cboxSistema.SelectedValue);
                        comando.Parameters.AddWithValue("@id_Tabla", cboxTabla.SelectedValue); //este es para ya modificar 
                        comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        comando.Parameters.AddWithValue("@script", txtConsulta.Text);
                        comando.ExecuteNonQuery();//es para verificar los editados
                        MessageBox.Show(" Guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConsulta.Clear();
                        txtDescripcion.Clear();
                        cboxSistema.ResetText();
                        cboxTabla.ResetText();
                        maximo();

                    }
                    break;
                case 1:
                    string query1 = "delete from Consultas where id=@id";
                    SqlCommand comandoo = new SqlCommand(query1, cone);
                    comandoo.Parameters.Clear();
                    comandoo.Parameters.AddWithValue("@id", txtClave.Text);
                    if (MessageBox.Show("El registro sera eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        comandoo.ExecuteNonQuery();
                        MessageBox.Show("Se ha eliminado el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    limpiar();
                    maximo();
                    break;

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtConsulta.Text) && txtDescripcion.Text.Trim() != "" && txtConsulta.Text.Trim() != "")
            {
                tbtGuardar.Enabled = true;
            }
            else
            {
                tbtGuardar.Enabled = false;

            }
        }
    }
}
