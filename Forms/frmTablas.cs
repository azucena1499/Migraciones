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
        private Boolean existe;
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
            
        }
     

        private void frmTablas_Load(object sender, EventArgs e)
        {
            maximo();

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtdescripcion.Text)  && txtdescripcion.Text.Trim() != "")
            {
                toolGuardar.Enabled = true;
            }
            else
            {
                toolGuardar.Enabled = false;

            }
        }

        private void toolBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Migraciones.Forms.frmBusquedaTabla frm = new Migraciones.Forms.frmBusquedaTabla(objConexionPrincipal);
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    txtclave.Focus();
                    txtclave.Text = frm.dgBusquedaT.Rows[frm.dgBusquedaT.CurrentRow.Index].Cells[0].Value.ToString();
                    txtdescripcion.Text = frm.dgBusquedaT.Rows[frm.dgBusquedaT.CurrentRow.Index].Cells[1].Value.ToString();
                    existe = true;
                }
                else
                {
                    existe = false;

                }

            }
         
            
          
            catch (SqlException err)
            {
                MessageBox.Show("Error en busqueda: " + err.Message, "Error Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolGuardar_Click(object sender, EventArgs e)
        {
            if (!existe)
            {
                cone = new SqlConnection(objConexionPrincipal.getConexion());
                //se abre la conexion
                cone.Open();
                string query = "insert into Tablas values(@id,@descripcion)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);

                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("Registro guardado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescripcion.Clear();
                //txtClave.Clear();
               
            }
            if (existe)
            {
                cone = new SqlConnection(objConexionPrincipal.getConexion());
                //se abre la conexion
                cone.Open();
                string query = "update Tablas set id=@id,descripcion=@descripcion where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            string query1 = "delete from Tablas where id=@id";
            SqlCommand comandoo = new SqlCommand(query1, cone);
            comandoo.Parameters.Clear();
            comandoo.Parameters.AddWithValue("@id", txtclave.Text);
            if (MessageBox.Show("El registro será  eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comandoo.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtdescripcion.Clear();
            txtclave.Clear();
            maximo();

        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            existe = false;

            txtdescripcion.Clear();
            txtclave.Clear();
            txtclave.Focus();
            maximo();
        }
    }
}
