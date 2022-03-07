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
        Clases.Conexion objconexion;
        SqlConnection cone;
        int existe = 0;

        public frmSistemas()
        {
            InitializeComponent();
        }

        private void maximo()
        {
            objconexion = new Clases.Conexion();
            cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
            Tbtneliminar.Enabled = false;
        }

 
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (existe == 0)
            //{
            //    objconexion = new Clases.Conexion();
            //    cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
            //    //se abre la conexion
            //    cone.Open();
            //    string query = "insert into Sistemas values(@id,@nombre,@estatus)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
            //    SqlCommand comando = new SqlCommand(query, cone);
            //    comando.Parameters.Clear();
            //    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
            //    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            //    comando.Parameters.AddWithValue("@estatus", cboxBuscar.SelectedIndex);

            //    comando.ExecuteNonQuery();//es para verificar los editados
            //    MessageBox.Show("Sistema guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnGuardar.Enabled = false;
            //    txtNombre.Clear();
            //    txtClave.Clear();

            //}
            //if (existe == 1)
            //{
            //    //fue un 0
            //    objconexion = new Clases.Conexion();
            //    cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
            //    //se abre la conexion
            //    cone.Open();
            //    string query = "update Sistemas set id=@id,nombre=@nombre where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
            //    SqlCommand comando = new SqlCommand(query, cone);
            //    comando.Parameters.Clear();
            //    comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
            //    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            //    comando.Parameters.AddWithValue("@estatus", cboxBuscar.SelectedIndex);

            //    comando.ExecuteNonQuery();
            //    MessageBox.Show("Sistema modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //dejar el forms como el inicio
            //    btnBuscar.Enabled = false;
            //    txtNombre.Clear();
            //    txtClave.Clear();
            //}
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
            objconexion = new Clases.Conexion();
            cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
                MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                //txtClave.Clear();
                txtBusueda.Focus();
            }
            else
            {
                //no fue nulo
                objconexion = new Clases.Conexion();
                cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
                    Tbtneliminar.Enabled = true;


                    //igualo los campos o columnas al txtnombre
                    txtNombre.Text = leer["nombre"].ToString();
                    txtClave.Text = leer["id"].ToString();
                }
                else
                {
                    //si la variable existe vale 0 y se usara insert
                    Tbtneliminar.Enabled = false;
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



        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {

                case 0:
                    if (existe == 0)
                    {
                        objconexion = new Clases.Conexion();
                        cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
                        objconexion = new Clases.Conexion();
                        cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
                    if (MessageBox.Show("El Sistema se dara de baja,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        comandoo.ExecuteNonQuery();

                        MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    limpiar();
                    maximo();
                    break;
                case 2:
                    MessageBox.Show("Third toolbar button clicked");
                    break;
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
                    objconexion = new Clases.Conexion();
                    cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
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
    }
    
}
