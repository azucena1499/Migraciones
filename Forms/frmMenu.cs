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
    public partial class frmMenu : Form
    {
        private Clases.Conexion objConexionPrincipal;
        public frmMenu(Clases.Conexion objConexionPrincipal)
        {
            this.objConexionPrincipal = objConexionPrincipal;
            InitializeComponent();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void capturaDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemas ventanaSistema = new frmSistemas(this.objConexionPrincipal);
            ventanaSistema.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
