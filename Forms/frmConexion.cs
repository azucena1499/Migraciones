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
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }


        private void validarCampos()
        {  //si no estan vacios los txt se habilita btn
            if (!string.IsNullOrEmpty(txtServidor.Text) && txtServidor.Text.Trim() != "" && !string.IsNullOrEmpty(txtInstancia.Text) && txtInstancia.Text.Trim() != "")
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;

            }

        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Conexion objConexionPrincipal = new Clases.Conexion(txtServidor.Text, txtInstancia.Text, txtUsuario.Text, txtContraseña.Text);
                SqlConnection cone = new SqlConnection(objConexionPrincipal.getConexion());
                cone.Open();

                //frmSistemas sistema = new frmSistemas(objConexionPrincipal);
                frmMenu menu = new frmMenu(objConexionPrincipal);
                menu.Show();
                //sistema.Show();
                this.Hide();

            }
            catch(SqlException exe)
            {
                MessageBox.Show("Error:falló la conexión,verifique los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtInstancia_TextChanged(object sender, EventArgs e)
        {
            validarCampos();

        }
    }
}
