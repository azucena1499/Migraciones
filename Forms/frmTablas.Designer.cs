
namespace Migraciones.Forms
{
    partial class frmTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablas));
            this.lblclave = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tlbguardar = new System.Windows.Forms.ToolBarButton();
            this.tbteliminar = new System.Windows.Forms.ToolBarButton();
            this.SuspendLayout();
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Location = new System.Drawing.Point(40, 64);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(34, 13);
            this.lblclave.TabIndex = 0;
            this.lblclave.Text = "Clave";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(134, 64);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Descripción";
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.Location = new System.Drawing.Point(29, 80);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(54, 20);
            this.txtclave.TabIndex = 2;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(118, 80);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(172, 20);
            this.txtdescripcion.TabIndex = 3;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tlbguardar,
            this.tbteliminar});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(394, 28);
            this.toolBar1.TabIndex = 4;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1447201522_save.png");
            this.imageList1.Images.SetKeyName(1, "1447201818_trash.png");
            // 
            // tlbguardar
            // 
            this.tlbguardar.Enabled = false;
            this.tlbguardar.ImageIndex = 0;
            this.tlbguardar.Name = "tlbguardar";
            // 
            // tbteliminar
            // 
            this.tbteliminar.Enabled = false;
            this.tbteliminar.ImageIndex = 1;
            this.tbteliminar.Name = "tbteliminar";
            // 
            // frmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 225);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblclave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Tablas";
            this.Load += new System.EventHandler(this.frmTablas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tlbguardar;
        private System.Windows.Forms.ToolBarButton tbteliminar;
        private System.Windows.Forms.ImageList imageList1;
    }
}