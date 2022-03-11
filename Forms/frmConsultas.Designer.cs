
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
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbtGuardar = new System.Windows.Forms.ToolBarButton();
            this.Tbtneliminar = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblClaveS
            // 
            this.lblClaveS.AutoSize = true;
            this.lblClaveS.Location = new System.Drawing.Point(109, 80);
            this.lblClaveS.Name = "lblClaveS";
            this.lblClaveS.Size = new System.Drawing.Size(47, 13);
            this.lblClaveS.TabIndex = 0;
            this.lblClaveS.Text = " Sistema";
            // 
            // cboxSistema
            // 
            this.cboxSistema.FormattingEnabled = true;
            this.cboxSistema.Location = new System.Drawing.Point(86, 96);
            this.cboxSistema.Name = "cboxSistema";
            this.cboxSistema.Size = new System.Drawing.Size(211, 21);
            this.cboxSistema.TabIndex = 1;
            // 
            // cboxTabla
            // 
            this.cboxTabla.FormattingEnabled = true;
            this.cboxTabla.Location = new System.Drawing.Point(323, 96);
            this.cboxTabla.Name = "cboxTabla";
            this.cboxTabla.Size = new System.Drawing.Size(200, 21);
            this.cboxTabla.TabIndex = 3;
            // 
            // lblClaveT
            // 
            this.lblClaveT.AutoSize = true;
            this.lblClaveT.Location = new System.Drawing.Point(371, 79);
            this.lblClaveT.Name = "lblClaveT";
            this.lblClaveT.Size = new System.Drawing.Size(37, 13);
            this.lblClaveT.TabIndex = 2;
            this.lblClaveT.Text = " Tabla";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(1, 95);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(54, 22);
            this.txtClave.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(8, 79);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(323, 198);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 75);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(435, 170);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(1, 198);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(296, 74);
            this.txtConsulta.TabIndex = 17;
            // 
            // toolBar1
            // 
            this.toolBar1.AutoSize = false;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbtGuardar,
            this.Tbtneliminar});
            this.toolBar1.ButtonSize = new System.Drawing.Size(50, 50);
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(679, 39);
            this.toolBar1.TabIndex = 18;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbtGuardar
            // 
            this.tbtGuardar.Enabled = false;
            this.tbtGuardar.ImageIndex = 0;
            this.tbtGuardar.Name = "toolBarButton1";
            // 
            // Tbtneliminar
            // 
            this.Tbtneliminar.Enabled = false;
            this.Tbtneliminar.ImageIndex = 1;
            this.Tbtneliminar.Name = "Tbtneliminar";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1447201081_save.png");
            this.imageList1.Images.SetKeyName(1, "1447201818_trash.png");
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 361);
            this.Controls.Add(this.toolBar1);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
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
        private System.Windows.Forms.ToolBar toolBar1;
        public System.Windows.Forms.ToolBarButton Tbtneliminar;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolBarButton tbtGuardar;
    }
}