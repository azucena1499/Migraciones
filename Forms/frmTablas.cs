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
    
    public partial class frmTablas : Form
    {
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;
        private int existe = 0;
        public frmTablas(Clases.Conexion objConexionPrincipal)
        {
            this.objConexionPrincipal = objConexionPrincipal;

            InitializeComponent();
        }
        private void maximo()
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT max(id)+1 as ultimo from Tablas";
            SqlCommand comando = new SqlCommand(query, cone);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtclave.Text = leer["ultimo"].ToString();
                if (txtclave.Text == "")
                {
                    txtclave.Text = "1";
                }
            }
        }


        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0:
                    //if (existe == 0)
                    
                        cone = new SqlConnection(objConexionPrincipal.getConexion());
                        cone.Open();
                        string query = "insert into Tablas values(@id,@descripcion)";                                                                                                            //asigno a comando el sqlcommand
                        SqlCommand comando = new SqlCommand(query, cone);
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@id", txtclave.Text);
                        comando.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                        comando.ExecuteNonQuery();//es para verificar los editados
                        MessageBox.Show(" Guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtclave.Clear();
                        txtdescripcion.Clear();
                        maximo();

                    
                    break;
                case 1:
                    string query1 = "delete from Consultas where id=@id";
                    SqlCommand comandoo = new SqlCommand(query1, cone);
                    comandoo.Parameters.Clear();
                    comandoo.Parameters.AddWithValue("@id", txtclave.Text);
                    if (MessageBox.Show("El registro sera eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        comandoo.ExecuteNonQuery();
                        MessageBox.Show("Se ha eliminado el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtdescripcion.Clear();
                    txtclave.Clear();
                    maximo();
                    break;

            }
        }
     

        private void frmTablas_Load(object sender, EventArgs e)
        {
            maximo();

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtdescripcion.Text)  && txtdescripcion.Text.Trim() != "")
            {
                tlbguardar.Enabled = true;
            }
            else
            {
                tlbguardar.Enabled = false;

            }
        }
    }
}
