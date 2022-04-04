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

        //public frmMenu(Clases.Conexion objConexionPrincipal)
        //{
        //    this.objConexionPrincipal = objConexionPrincipal;
        //    InitializeComponent();
        //}

        public frmMenu()
        {

            InitializeComponent();
        }
        private void mostrarFrmConexionPrincipal()
        {
           frmConexion frm = new frmConexion();
            frm.ShowDialog();
            this.objConexionPrincipal = frm.objConexionPrincipal;

            if (this.objConexionPrincipal == null)//si falla conexion es nulo 
            {
                MessageBox.Show("Se necesita establecer una  conexión");

            }

        }
        private void mostrarFrmSistemas()
        {

            frmSistemas frm = new frmSistemas(this.objConexionPrincipal);
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.Show();
        }
        private void mostrarFrmTabla()
        {

            frmTablas frm = new frmTablas(this.objConexionPrincipal);
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.Show();
        }
        private void mostrarFrmConsulta()
        {

            frmConsultas frm = new frmConsultas(this.objConexionPrincipal);
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.Show();
        }
        private void mostarFrmConexion()
        {
            frmConexionOrigen frm = new frmConexionOrigen(this.objConexionPrincipal);
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.Show();
        }


        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemas ventanaSistema = new frmSistemas(this.objConexionPrincipal);
            ventanaSistema.Show();

        }

        private void capturaDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {


            mostrarFrmConexionPrincipal();
  

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sistemasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(this.objConexionPrincipal!=null)
            {
                mostrarFrmSistemas();
            }
            else
            {
                mostrarFrmConexionPrincipal();
                if(this.objConexionPrincipal!=null)
                {
                    mostrarFrmSistemas();
                }
            }
            
        }

        private void tablasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.objConexionPrincipal != null)
            {
                mostrarFrmTabla();
            }
            else
            {
                mostrarFrmConexionPrincipal();
                if (this.objConexionPrincipal != null)
                {
                    mostrarFrmTabla();
                }
            }

        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.objConexionPrincipal != null)
            {
                mostrarFrmConsulta();
            }
            else
            {
                mostrarFrmConexionPrincipal();
                if (this.objConexionPrincipal != null)
                {
                    mostrarFrmConsulta();
                }
            }
        }

        private void conexionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.objConexionPrincipal != null)
            {
                mostarFrmConexion();
            }
            else
            {
                mostrarFrmConexionPrincipal();
                if (this.objConexionPrincipal != null)
                {
                    mostarFrmConexion();
                }
            }
        }
    }
}
