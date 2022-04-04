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
    public partial class frmConexionOrigen : Form
    {

        private Clases.Conexion objConexion;
        private SqlConnection cone;
        private Boolean existe;
        public frmConexionOrigen(Clases.Conexion objConexion)
        {
            this.objConexion = objConexion;
            InitializeComponent();
        }
        private void llenarcboxSistema()
        {
            DataTable dt = new DataTable();
            cone = new SqlConnection(objConexion.getConexion());
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
        private void maximo()
        {
            cone = new SqlConnection(objConexion.getConexion());
            cone.Open();
            string query = "SELECT max(id)+1 as ultimo from ConexionesOrigen";
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
            txtContraseña.Clear();
            txtServidor.Focus();
            txtEmpresa.Clear();
            txtInstancia.Clear();
            cboxSistema.SelectedValue = 0;
            txtServidor.Clear();
            txtClave.Clear();
            txtBaseDatos.Clear();
            maximo();
        }
        
        private void toolGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!existe)
                {
                    cone = new SqlConnection(objConexion.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "insert into ConexionesOrigen values(@id,@id_SistemaC,@servidor,@instancia,@contraseña,@empresaC,@base_datos,@usuarioC)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", txtClave.Text); 
                    comando.Parameters.AddWithValue("@id_SistemaC", cboxSistema.SelectedValue);
                    comando.Parameters.AddWithValue("@servidor", txtServidor.Text);
                    comando.Parameters.AddWithValue("@instancia", txtInstancia.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                    comando.Parameters.AddWithValue("@empresaC", txtEmpresa.Text);
                    comando.Parameters.AddWithValue("@base_datos", txtBaseDatos.Text);
                    comando.Parameters.AddWithValue("@usuarioC", txtUsuario.Text);


                    comando.ExecuteNonQuery();
                    MessageBox.Show("Conexiones Origen guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (existe)
                {
                    cone = new SqlConnection(objConexion.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "update ConexionesOrigen set id=@id,id_SistemaC=@id_SistemaC,servidor=@servidor,instancia=@instancia,contraseña=@contraseña,empresaC=@empresaC,base_datos=@base_datos,usuarioC=@usuarioC where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", txtClave.Text); 
                    comando.Parameters.AddWithValue("@id_SistemaC", cboxSistema.SelectedValue);
                    comando.Parameters.AddWithValue("@servidor", txtServidor.Text);
                    comando.Parameters.AddWithValue("@instancia", txtInstancia.Text);
                    comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                    comando.Parameters.AddWithValue("@empresaC", txtEmpresa.Text);
                    comando.Parameters.AddWithValue("@base_datos", txtBaseDatos.Text);
                    comando.Parameters.AddWithValue("@usuarioC", txtUsuario.Text);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Conexiones Origen modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en Conexiones: " + err.Message, "Error Conexiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void frmConexionOrigen_Load(object sender, EventArgs e)
        {
            llenarcboxSistema();
            maximo();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "delete from ConexionesOrigen where id=@id";
                SqlCommand comandoo = new SqlCommand(query1, cone);
                comandoo.Parameters.Clear();
                comandoo.Parameters.AddWithValue("@id", txtClave.Text);
                if (MessageBox.Show("La conexión sera eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    comandoo.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado la conexión", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiar();
                maximo();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en consulta: " + err.Message, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }

        private void toolBuscar_Click(object sender, EventArgs e)
        {
            Migraciones.Forms.frmBusquedaConexionesOrigen frm = new Migraciones.Forms.frmBusquedaConexionesOrigen(objConexion);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                txtClave.Focus();
                txtClave.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[0].Value.ToString();
                cboxSistema.SelectedValue = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[1].Value.ToString();
                txtServidor.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[3].Value.ToString();
                txtInstancia.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[4].Value.ToString();
                txtContraseña.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[5].Value.ToString();
                txtEmpresa.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[6].Value.ToString();
                txtBaseDatos.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[7].Value.ToString();
                txtUsuario.Text = frm.dgBusquedaConexion.Rows[frm.dgBusquedaConexion.CurrentRow.Index].Cells[8].Value.ToString();
                existe = true;
            }
            else
            {
                existe = false;

            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear conexion con la info ingresada
                // abrir conexion
                // habilitar guardar
                // Mensaje de conexion exitosa
                // cerrar conexion
                Clases.Conexion conexionOrigen = new Clases.Conexion(txtServidor.Text, txtInstancia.Text,txtUsuario.Text ,txtContraseña.Text);
                SqlConnection cone = new SqlConnection(conexionOrigen.getConexion());
                cone.Open();
                toolGuardar.Enabled = true;
                MessageBox.Show("Conexión exitosa", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cone.Close();



            }
            catch (SqlException err)
            {
                //mandar mensaje de conexion incorrecta
                MessageBox.Show("Error : " + err.Message, "Error conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Inactivar guardar
                toolGuardar.Enabled = false;

            }
        }
    }
}
