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
        private Boolean existe;

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
            txtConsulta.Clear();
            txtConsulta.Focus();
            //cboxSistema.ResetText();
            cboxSistema.SelectedIndex = 0;
            cboxTabla.SelectedIndex = 0;
            //cboxTabla.ResetText();
            toolEliminar.Enabled = false;
        }
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            llenarcboxSistema();
            llenarcboxTabla();
            maximo();

        }


        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ////if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtConsulta.Text) && txtDescripcion.Text.Trim() != "" && txtConsulta.Text.Trim() != "")
            //    if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtConsulta.Text) && txtConsulta.Text.Trim() != "" && txtDescripcion.Text.Trim() != "")

            // {
            //        toolGuardar.Enabled = true;
            //}
            //else
            //{
            //    toolGuardar.Enabled = false;

            //}
        }

        private void toolBuscar_Click(object sender, EventArgs e)
        {
            Migraciones.Forms.frmBusquedaConsulta frm = new Migraciones.Forms.frmBusquedaConsulta(objConexionPrincipal);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                txtClave.Focus();
                txtClave.Text = frm.dgBusquedaConsulta.Rows[frm.dgBusquedaConsulta.CurrentRow.Index].Cells[0].Value.ToString();
                cboxSistema.SelectedValue = frm.dgBusquedaConsulta.Rows[frm.dgBusquedaConsulta.CurrentRow.Index].Cells[5].Value.ToString();
                cboxTabla.SelectedValue = frm.dgBusquedaConsulta.Rows[frm.dgBusquedaConsulta.CurrentRow.Index].Cells[6].Value.ToString();
                txtDescripcion.Text = frm.dgBusquedaConsulta.Rows[frm.dgBusquedaConsulta.CurrentRow.Index].Cells[3].Value.ToString();
                txtConsulta.Text = frm.dgBusquedaConsulta.Rows[frm.dgBusquedaConsulta.CurrentRow.Index].Cells[4].Value.ToString();

                existe = true;
            }
            else
            {
                existe = false;

            }
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
                    string query = "insert into Consultas values(@id_Sistema,@id_Tabla,@descripcion,@script)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", txtClave.Text);
                    comando.Parameters.AddWithValue("@id_Sistema", cboxSistema.SelectedValue);
                    comando.Parameters.AddWithValue("@id_Tabla", cboxTabla.SelectedValue);
                    comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@script", txtConsulta.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Consulta guardada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtClave.Clear();
                }
                if (existe)
                {
                    cone = new SqlConnection(objConexionPrincipal.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "update Consultas set id_Sistema=@id_Sistema,id_Tabla=@id_Tabla,descripcion=@descripcion,script=@script where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text));
                    comando.Parameters.AddWithValue("@id_Sistema", cboxSistema.SelectedValue);
                    comando.Parameters.AddWithValue("@id_Tabla", cboxTabla.SelectedValue); //este es para ya modificar 
                    comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@script", txtConsulta.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("consulta modificada con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en consulta: " + err.Message, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
           
            limpiar();
            maximo();
        }

        private void cboxSistema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                string query1 = "delete from Consultas where id=@id";
                SqlCommand comandoo = new SqlCommand(query1, cone);
                comandoo.Parameters.Clear();
                comandoo.Parameters.AddWithValue("@id", txtClave.Text);
                if (MessageBox.Show("La consulta sera eliminado,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    comandoo.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado la consulta", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiar();
                maximo();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en consulta: " + err.Message, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
