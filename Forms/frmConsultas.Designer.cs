
namespace Migraciones.Forms
{
    partial class frmConsultas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.lblClaveS = new System.Windows.Forms.Label();
            this.cboxSistema = new System.Windows.Forms.ComboBox();
            this.cboxTabla = new System.Windows.Forms.ComboBox();
            this.lblClaveT = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaveS
            // 
            this.lblClaveS.AutoSize = true;
            this.lblClaveS.Location = new System.Drawing.Point(18, 89);
            this.lblClaveS.Name = "lblClaveS";
            this.lblClaveS.Size = new System.Drawing.Size(47, 13);
            this.lblClaveS.TabIndex = 0;
            this.lblClaveS.Text = " Sistema";
            // 
            // cboxSistema
            // 
            this.cboxSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSistema.FormattingEnabled = true;
            this.cboxSistema.Location = new System.Drawing.Point(89, 85);
            this.cboxSistema.Name = "cboxSistema";
            this.cboxSistema.Size = new System.Drawing.Size(211, 21);
            this.cboxSistema.TabIndex = 1;
            this.cboxSistema.SelectedIndexChanged += new System.EventHandler(this.cboxSistema_SelectedIndexChanged);
            // 
            // cboxTabla
            // 
            this.cboxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTabla.FormattingEnabled = true;
            this.cboxTabla.Location = new System.Drawing.Point(89, 112);
            this.cboxTabla.Name = "cboxTabla";
            this.cboxTabla.Size = new System.Drawing.Size(211, 21);
            this.cboxTabla.TabIndex = 3;
            // 
            // lblClaveT
            // 
            this.lblClaveT.AutoSize = true;
            this.lblClaveT.Location = new System.Drawing.Point(18, 120);
            this.lblClaveT.Name = "lblClaveT";
            this.lblClaveT.Size = new System.Drawing.Size(37, 13);
            this.lblClaveT.TabIndex = 2;
            this.lblClaveT.Text = " Tabla";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(89, 51);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(93, 22);
            this.txtClave.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(18, 56);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(89, 145);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(745, 75);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 159);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(89, 233);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsulta.Size = new System.Drawing.Size(745, 234);
            this.txtConsulta.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1447201081_save.png");
            this.imageList1.Images.SetKeyName(1, "1447201818_trash.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolGuardar,
            this.toolBuscar,
            this.toolEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 39);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(36, 36);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolGuardar
            // 
            this.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(36, 36);
            this.toolGuardar.Text = "toolBar";
            this.toolGuardar.Click += new System.EventHandler(this.toolGuardar_Click);
            // 
            // toolBuscar
            // 
            this.toolBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolBuscar.Image")));
            this.toolBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBuscar.Name = "toolBuscar";
            this.toolBuscar.Size = new System.Drawing.Size(36, 36);
            this.toolBuscar.Text = "toolStripButton2";
            this.toolBuscar.ToolTipText = "Buscar";
            this.toolBuscar.Click += new System.EventHandler(this.toolBuscar_Click);
            // 
            // toolEliminar
            // 
            this.toolEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolEliminar.Image")));
            this.toolEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(36, 36);
            this.toolEliminar.Text = "toolEliminar";
            this.toolEliminar.ToolTipText = "toolEliminar";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cboxTabla);
            this.Controls.Add(this.lblClaveT);
            this.Controls.Add(this.cboxSistema);
            this.Controls.Add(this.lblClaveS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveS;
        private System.Windows.Forms.ComboBox cboxSistema;
        private System.Windows.Forms.ComboBox cboxTabla;
        private System.Windows.Forms.Label lblClaveT;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolBarButton tbtGuardar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripButton toolBuscar;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}