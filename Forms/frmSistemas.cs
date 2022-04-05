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
using Migraciones.Clases;

namespace Migraciones
{
    public partial class frmSistemas : Form
    {
        private Clases.Conexion objConexionPrincipal;
        private SqlConnection cone;
        private Boolean existe;

        public frmSistemas(Clases.Conexion objConexionPrincipal)
        {
            this.objConexionPrincipal = objConexionPrincipal;
            InitializeComponent();
        }

        private void maximo()
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            cone.Open();
            string query = "SELECT max(id)+1 as ultimo from Sistemas";
            SqlCommand comando = new SqlCommand(query, cone);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtClave.Text = leer["ultimo"].ToString();
        }

        private void limpiar()
        {


            txtNombre.Clear();
            txtClave.Clear();
            
            //tbteliminar.Enabled = false;
        }
        private void frmSistemas_Load(object sender, EventArgs e)
        {
            maximo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cone = new SqlConnection(objConexionPrincipal.getConexion());
        //        //se abre la conexion
        //        cone.Open();
        //        string query = "update Sistemas set estatus=0 where id=id";
        //        SqlCommand comando = new SqlCommand(query, cone);
        //        comando.Parameters.Clear();
        //        comando.Parameters.AddWithValue("@id", txtClave.Text);
        //        if (MessageBox.Show("El Sistema se dara de baja,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Stop) == DialogResult.Yes)
        //        {
        //            comando.ExecuteNonQuery();

        //            MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        limpiar();
        //    }

        //    catch (SqlException err)
        //    {
        //        MessageBox.Show("Error de base de datos: " + err.Message, "Error busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClave.Text) && !string.IsNullOrEmpty(txtNombre.Text) && txtClave.Text.Trim() != "" && txtNombre.Text.Trim() != "")
            {
                toolGuardar.Enabled = true;
            }
            else
            {
                toolGuardar.Enabled = false;

            }
        }



        private void txtBusueda_TextChanged(object sender, EventArgs e)
        {
            //if (txtBusueda.Text != "")
            //{
            //    btnBuscar.Enabled = true;

            //}
            //else
            //{
            //    btnBuscar.Enabled = false;

            //}

        }



        private void toolBuscar_Click(object sender, EventArgs e)
        {
            Migraciones.Forms.frmBusquedaSistema frm = new Migraciones.Forms.frmBusquedaSistema(objConexionPrincipal);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                txtClave.Focus();
                txtClave.Text = frm.dgBusqueda.Rows[frm.dgBusqueda.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombre.Text = frm.dgBusqueda.Rows[frm.dgBusqueda.CurrentRow.Index].Cells[1].Value.ToString();
                existe = true;
            }
            else
            {
                existe = false;

            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            existe = false;

            maximo();
        }

        private void toolGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!existe)
                {
                    cone = new SqlConnection(objConexionPrincipal.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "insert into Sistemas values(@id,@nombre)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);

                    comando.ExecuteNonQuery();//es para verificar los editados
                    MessageBox.Show("Sistema guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    maximo();
                }
                if (existe)
                {
                    cone = new SqlConnection(objConexionPrincipal.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "update Sistemas set id=@id,nombre=@nombre where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sistema modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en Sistema: " + err.Message, "Error Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "delete from Sistemas where id=@id";
                SqlCommand comandoo = new SqlCommand(query1, cone);
                comandoo.Parameters.Clear();
                comandoo.Parameters.AddWithValue("@id", txtClave.Text);
                if (MessageBox.Show("El Sistema sera eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    comandoo.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiar();
                maximo();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en consulta: " + err.Message, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
 

