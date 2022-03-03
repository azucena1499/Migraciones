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
        int existe=1;
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
        private void llenarcbox()
        {
            DataTable dt = new DataTable();
            objconexion = new Clases.Conexion();
            cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
            cone.Open();
            string query = "SELECT * from Sistemas where id >=1 order by nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, cone);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxBuscar.DataSource = dt;
            this.cboxBuscar.ValueMember = "id";
            this.cboxBuscar.DisplayMember = "nombre";
            //Conexion.Close();

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtClave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maximo();
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
                    //asigno a leer el sqldatareader para leer el registro.
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtNombre.Enabled = true;
                        txtNombre.Focus();
                        txtClave.Enabled = false;
                        //txtClave.Clear();
                        btnGuardar.Enabled = true;
                        btnBuscar.Enabled = true;

                        //igualo los campos o columnas al txtnombre
                        txtNombre.Text = leer["nombre"].ToString();
                        txtEmpresa.Text = leer["empresa"].ToString();
                    }
                    else
                    {
                        existe = 0;
                        if (MessageBox.Show("Sistema no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            txtNombre.Enabled = true;
                            btnGuardar.Enabled = true;
                            txtNombre.Focus();
                            //txtClave.Enabled = true;
                            maximo();
                        }

                    }
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.Conexion();
                cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
                //se abre la conexion
                cone.Open();
                string query = "insert into Sistemas values(@id,@nombre,@empresa)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@empresa", txtEmpresa.Text);
                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("Sistema guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                txtNombre.Clear();
                txtClave.Enabled = true;
                txtClave.Clear();
                txtClave.Focus();
                txtEmpresa.Clear();

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new Clases.Conexion();
                cone = new SqlConnection(objconexion.Conn("DESKTOP-4CSQT06", "BMS_MIGRACIONES", "azucenagm", "1499"));
                //se abre la conexion
                cone.Open();
                string query = "update Sistemas set id=@id,nombre=@nombre,empresa=@empresa where id=@id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, cone);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", int.Parse(txtClave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@empresa", txtEmpresa.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Sistema modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnBuscar.Enabled = false;
                txtNombre.Clear();
                txtClave.Enabled = true;
                txtClave.Clear();
                txtClave.Focus();
                txtEmpresa.Clear();
            }
        }

        private void frmSistemas_Load(object sender, EventArgs e)
        {
            maximo();
            txtClave.Focus();
            llenarcbox();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cboxBuscar.Visible = true;


        }

        private void cboxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtClave.Text = this.cboxBuscar.SelectedValue.ToString();
                //valido
                cboxBuscar.Visible = false;
                cboxBuscar.Enabled = true;
                txtClave.Focus();
            }
            
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
