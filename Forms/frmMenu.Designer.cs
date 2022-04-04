
namespace Migraciones.Forms
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraerDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarLayoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.extraerDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem1,
            this.tablasToolStripMenuItem1,
            this.conexionesToolStripMenuItem1,
            this.consultasToolStripMenuItem1});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // sistemasToolStripMenuItem1
            // 
            this.sistemasToolStripMenuItem1.Name = "sistemasToolStripMenuItem1";
            this.sistemasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sistemasToolStripMenuItem1.Text = "Sistemas";
            this.sistemasToolStripMenuItem1.Click += new System.EventHandler(this.sistemasToolStripMenuItem1_Click);
            // 
            // tablasToolStripMenuItem1
            // 
            this.tablasToolStripMenuItem1.Name = "tablasToolStripMenuItem1";
            this.tablasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tablasToolStripMenuItem1.Text = "Tablas";
            this.tablasToolStripMenuItem1.Click += new System.EventHandler(this.tablasToolStripMenuItem1_Click);
            // 
            // conexionesToolStripMenuItem1
            // 
            this.conexionesToolStripMenuItem1.Name = "conexionesToolStripMenuItem1";
            this.conexionesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.conexionesToolStripMenuItem1.Text = "Conexiones";
            this.conexionesToolStripMenuItem1.Click += new System.EventHandler(this.conexionesToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            this.consultasToolStripMenuItem1.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // extraerDatosToolStripMenuItem
            // 
            this.extraerDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarLayoutsToolStripMenuItem,
            this.configurarConexionToolStripMenuItem});
            this.extraerDatosToolStripMenuItem.Name = "extraerDatosToolStripMenuItem";
            this.extraerDatosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.extraerDatosToolStripMenuItem.Text = "Extraer datos";
            // 
            // generarLayoutsToolStripMenuItem
            // 
            this.generarLayoutsToolStripMenuItem.Name = "generarLayoutsToolStripMenuItem";
            this.generarLayoutsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.generarLayoutsToolStripMenuItem.Text = "Generar Layouts";
            // 
            // configurarConexionToolStripMenuItem
            // 
            this.configurarConexionToolStripMenuItem.Name = "configurarConexionToolStripMenuItem";
            this.configurarConexionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.configurarConexionToolStripMenuItem.Text = "Configurar Conexion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conexionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extraerDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarLayoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarConexionToolStripMenuItem;
    }
}