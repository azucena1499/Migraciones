
namespace Migraciones.Forms
{
    partial class frmConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexion));
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblinstancia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtbaseDatos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtinstancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(228, 22);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor";
            // 
            // lblinstancia
            // 
            this.lblinstancia.AutoSize = true;
            this.lblinstancia.Location = new System.Drawing.Point(209, 85);
            this.lblinstancia.Name = "lblinstancia";
            this.lblinstancia.Size = new System.Drawing.Size(50, 13);
            this.lblinstancia.TabIndex = 1;
            this.lblinstancia.Text = "Instancia";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(218, 225);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(209, 301);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(161, 48);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(181, 20);
            this.txtServidor.TabIndex = 4;
            this.txtServidor.Text = "DESKTOP-4CSQT06";
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtbaseDatos
            // 
            this.txtbaseDatos.Location = new System.Drawing.Point(161, 187);
            this.txtbaseDatos.Name = "txtbaseDatos";
            this.txtbaseDatos.Size = new System.Drawing.Size(181, 20);
            this.txtbaseDatos.TabIndex = 5;
            this.txtbaseDatos.Text = "BMS_MIGRACIONES";
            this.txtbaseDatos.TextChanged += new System.EventHandler(this.txtInstancia_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 263);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Text = "azucenagm";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(161, 333);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(181, 20);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "1499";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.Location = new System.Drawing.Point(472, 333);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(41, 41);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtinstancia
            // 
            this.txtinstancia.Location = new System.Drawing.Point(161, 113);
            this.txtinstancia.Name = "txtinstancia";
            this.txtinstancia.Size = new System.Drawing.Size(181, 20);
            this.txtinstancia.TabIndex = 14;
            this.txtinstancia.Text = "dbo";
            this.txtinstancia.TextChanged += new System.EventHandler(this.txtinstancia_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Base de Datos";
            // 
            // frmConexion
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 386);
            this.Controls.Add(this.txtinstancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtbaseDatos);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblinstancia);
            this.Controls.Add(this.lblServidor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion Principal";
            this.Load += new System.EventHandler(this.frmConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblinstancia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtbaseDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtinstancia;
        private System.Windows.Forms.Label label1;
    }
}