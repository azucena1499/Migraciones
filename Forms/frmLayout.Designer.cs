
namespace Migraciones.Forms
{
    partial class frmLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayout));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolEjecutar = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSistema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxTabla = new System.Windows.Forms.ComboBox();
            this.lblClaveT = new System.Windows.Forms.Label();
            this.cboxConexion = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cboxConsulta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEjecutar,
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 39);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolEjecutar
            // 
            this.toolEjecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("toolEjecutar.Image")));
            this.toolEjecutar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEjecutar.Name = "toolEjecutar";
            this.toolEjecutar.Size = new System.Drawing.Size(34, 36);
            this.toolEjecutar.Text = "toolStripButton2";
            this.toolEjecutar.ToolTipText = "Buscar";
            this.toolEjecutar.Click += new System.EventHandler(this.toolEjecutar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 36);
            this.btnExcel.Text = "toolStripButton1";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Conexion";
            // 
            // cboxSistema
            // 
            this.cboxSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSistema.Enabled = false;
            this.cboxSistema.FormattingEnabled = true;
            this.cboxSistema.Items.AddRange(new object[] {
            "Seleccione"});
            this.cboxSistema.Location = new System.Drawing.Point(358, 48);
            this.cboxSistema.Name = "cboxSistema";
            this.cboxSistema.Size = new System.Drawing.Size(211, 21);
            this.cboxSistema.TabIndex = 28;
            this.cboxSistema.SelectedIndexChanged += new System.EventHandler(this.cboxSistema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sistema";
            // 
            // cboxTabla
            // 
            this.cboxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTabla.FormattingEnabled = true;
            this.cboxTabla.Items.AddRange(new object[] {
            "Seleccione"});
            this.cboxTabla.Location = new System.Drawing.Point(80, 74);
            this.cboxTabla.Name = "cboxTabla";
            this.cboxTabla.Size = new System.Drawing.Size(211, 21);
            this.cboxTabla.TabIndex = 30;
            this.cboxTabla.SelectedIndexChanged += new System.EventHandler(this.cboxTabla_SelectedIndexChanged);
            // 
            // lblClaveT
            // 
            this.lblClaveT.AutoSize = true;
            this.lblClaveT.Location = new System.Drawing.Point(21, 77);
            this.lblClaveT.Name = "lblClaveT";
            this.lblClaveT.Size = new System.Drawing.Size(37, 13);
            this.lblClaveT.TabIndex = 29;
            this.lblClaveT.Text = " Tabla";
            // 
            // cboxConexion
            // 
            this.cboxConexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxConexion.FormattingEnabled = true;
            this.cboxConexion.Location = new System.Drawing.Point(80, 47);
            this.cboxConexion.Name = "cboxConexion";
            this.cboxConexion.Size = new System.Drawing.Size(211, 21);
            this.cboxConexion.TabIndex = 31;
            this.cboxConexion.SelectedIndexChanged += new System.EventHandler(this.cboxConexion_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(8, 103);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(909, 312);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cboxConsulta
            // 
            this.cboxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxConsulta.Enabled = false;
            this.cboxConsulta.FormattingEnabled = true;
            this.cboxConsulta.Items.AddRange(new object[] {
            "Seleccione"});
            this.cboxConsulta.Location = new System.Drawing.Point(358, 77);
            this.cboxConsulta.Name = "cboxConsulta";
            this.cboxConsulta.Size = new System.Drawing.Size(211, 21);
            this.cboxConsulta.TabIndex = 35;
            this.cboxConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Consulta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.cboxConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cboxConexion);
            this.Controls.Add(this.cboxTabla);
            this.Controls.Add(this.lblClaveT);
            this.Controls.Add(this.cboxSistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLayout";
            this.Text = "frmLayout";
            this.Load += new System.EventHandler(this.frmLayout_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolEjecutar;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSistema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTabla;
        private System.Windows.Forms.Label lblClaveT;
        private System.Windows.Forms.ComboBox cboxConexion;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cboxConsulta;
        private System.Windows.Forms.Label label3;
    }
}