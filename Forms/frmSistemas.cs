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
       private int existe = 0;

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
            txtBusueda.Focus();
            tbteliminar.Enabled = false;
        }
        private void frmSistemas_Load(object sender, EventArgs e)
        {
            maximo();
            txtBusueda.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cone = new SqlConnection(objConexionPrincipal.getConexion());
            //se abre la conexion
            cone.Open();
            string query = "update Sistemas set estatus=0 where id=id";
            SqlCommand comando = new SqlCommand(query, cone);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", txtClave.Text);
            if (MessageBox.Show("El Sistema se dara de baja,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //chechando que no sea valor nulo o blanco
            if (string.IsNullOrEmpty(txtBusueda.Text))
            {
                MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                txtBusueda.Focus();
            }
            else
            {
                //no fue nulo
                cone = new SqlConnection(objConexionPrincipal.getConexion());
                //se abre la conexion
                cone.Open();
                string query = "select * from Sistemas where id=@id";
                //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, cone);

                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id", int.Parse(txtBusueda.Text));


                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    //inicializo la variable 1 para que el programa sepa que existe
                    existe = 1;
                    txtNombre.Enabled = true;
                    txtNombre.Focus();
                    txtClave.Enabled = false;
                    tbteliminar.Enabled = true;


                    //igualo los campos o columnas al txtnombre
                    txtNombre.Text = leer["nombre"].ToString();
                    txtClave.Text = leer["id"].ToString();
                }
                else
                {
                    //si la variable existe vale 0 y se usara insert
                    tbteliminar.Enabled = false;
                    limpiar();
                    maximo();

                    existe = 0;
                    if (MessageBox.Show("Sistema no registrado.¿desea agregar un nuevo sistema?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        //poner un habilitar aqui
                        txtNombre.Enabled = true;
                        txtNombre.Focus();
                       
                    }


                }
                leer.Close();
                    

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClave.Text) && !string.IsNullOrEmpty(txtNombre.Text)&& txtClave.Text.Trim()!="" && txtNombre.Text.Trim()!="")
            {
                tbtbguardarr.Enabled = true;
            }
            else
            {
                tbtbguardarr.Enabled = false;

            }
        }

        private void txtBusueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtClave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtClave.Clear();
                    txtBusueda.Focus();
                }
                else
                {
                    //no fue nulo
                    cone = new SqlConnection(objConexionPrincipal.getConexion());
                    //se abre la conexion
                    cone.Open();
                    string query = "select * from Sistemas where id=@id";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, cone);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text));
                    comando.Parameters.AddWithValue("@nombre", this.txtNombre.Text);

                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtNombre.Enabled = true;
                        txtNombre.Focus();
                        txtClave.Enabled = false;

                        //igualo los campos o columnas al txtnombre
                        txtNombre.Text = leer["nombre"].ToString();
                        txtClave.Text = leer["id"].ToString();

                    }
                    else
                    {
                        //si la variable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("Sistema no registrado.¿desea agregar un nuevo sistema?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //poner un habilitar aqui
                            txtNombre.Enabled = true;
                            txtNombre.Focus();

                        }

                    }
                }
        }

        private void txtBusueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusueda.Text != "")
            {
                btnBuscar.Enabled = true;

            }
            else
            {
                btnBuscar.Enabled = false;

            }
           
        }

        private void toolBar1_ButtonClick_1(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0:
                    if (existe == 0)
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
                        //txtClave.Clear();
                        txtBusueda.Focus();
                        maximo();

                    }
                    if (existe == 1)
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
                        //dejar el forms como el inicio
                        btnBuscar.Enabled = false;
                        txtNombre.Clear();
                        txtClave.Clear();
                        txtBusueda.Focus();
                    }
                    break;
                case 1:
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
                    txtBusueda.Clear();
                    limpiar();
                    maximo();
                    break;
            }
        }
    }
    
}
