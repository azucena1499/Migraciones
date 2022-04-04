
namespace Migraciones.Forms
{
    partial class frmBusquedaConexionesOrigen
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgBusquedaConexion = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaConexion)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1074, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtExpresion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 58);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(12, 13);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(145, 20);
            this.txtExpresion.TabIndex = 1;
            this.txtExpresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpresion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresión a Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(725, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(644, 395);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgBusquedaConexion
            // 
            this.dgBusquedaConexion.AllowUserToAddRows = false;
            this.dgBusquedaConexion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgBusquedaConexion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBusquedaConexion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.id_Sistema,
            this.nombre_sistema,
            this.servidor,
            this.instancia,
            this.contraseña,
            this.empresaa,
            this.base_datos,
            this.usuarioC});
            this.dgBusquedaConexion.Location = new System.Drawing.Point(0, 64);
            this.dgBusquedaConexion.Name = "dgBusquedaConexion";
            this.dgBusquedaConexion.ReadOnly = true;
            this.dgBusquedaConexion.Size = new System.Drawing.Size(1116, 325);
            this.dgBusquedaConexion.TabIndex = 25;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.HeaderText = "Clave";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // id_Sistema
            // 
            this.id_Sistema.DataPropertyName = "id_sistema";
            this.id_Sistema.HeaderText = "id sistema";
            this.id_Sistema.Name = "id_Sistema";
            this.id_Sistema.ReadOnly = true;
            this.id_Sistema.Visible = false;
            // 
            // nombre_sistema
            // 
            this.nombre_sistema.DataPropertyName = "nombre_sistema";
            this.nombre_sistema.HeaderText = " Sistema";
            this.nombre_sistema.Name = "nombre_sistema";
            this.nombre_sistema.ReadOnly = true;
            this.nombre_sistema.Width = 150;
            // 
            // servidor
            // 
            this.servidor.DataPropertyName = "servidor";
            this.servidor.HeaderText = "Servidor";
            this.servidor.Name = "servidor";
            this.servidor.ReadOnly = true;
            this.servidor.Width = 150;
            // 
            // instancia
            // 
            this.instancia.DataPropertyName = "instancia";
            this.instancia.HeaderText = "Instancia";
            this.instancia.Name = "instancia";
            this.instancia.ReadOnly = true;
            this.instancia.Width = 180;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Width = 150;
            // 
            // empresaa
            // 
            this.empresaa.DataPropertyName = "empresaC";
            this.empresaa.HeaderText = "Empresa";
            this.empresaa.Name = "empresaa";
            this.empresaa.ReadOnly = true;
            // 
            // base_datos
            // 
            this.base_datos.DataPropertyName = "base_datos";
            this.base_datos.HeaderText = "base de datos";
            this.base_datos.Name = "base_datos";
            this.base_datos.ReadOnly = true;
            // 
            // usuarioC
            // 
            this.usuarioC.DataPropertyName = "usuarioc";
            this.usuarioC.HeaderText = "Usuario";
            this.usuarioC.Name = "usuarioC";
            this.usuarioC.ReadOnly = true;
            // 
            // frmBusquedaConexionesOrigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgBusquedaConexion);
            this.Name = "frmBusquedaConexionesOrigen";
            this.Text = "frmBusquedaConexionesOrigen";
            this.Load += new System.EventHandler(this.frmBusquedaConexionesOrigen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaConexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataGridView dgBusquedaConexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn servidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn instancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn base_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioC;
    }
}