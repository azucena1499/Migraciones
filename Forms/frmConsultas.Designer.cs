
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.lblClaveS = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblClaveT = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClaveS
            // 
            this.lblClaveS.AutoSize = true;
            this.lblClaveS.Location = new System.Drawing.Point(144, 19);
            this.lblClaveS.Name = "lblClaveS";
            this.lblClaveS.Size = new System.Drawing.Size(74, 13);
            this.lblClaveS.TabIndex = 0;
            this.lblClaveS.Text = "Clave Sistema";
            this.lblClaveS.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(309, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // lblClaveT
            // 
            this.lblClaveT.AutoSize = true;
            this.lblClaveT.Location = new System.Drawing.Point(357, 18);
            this.lblClaveT.Name = "lblClaveT";
            this.lblClaveT.Size = new System.Drawing.Size(64, 13);
            this.lblClaveT.TabIndex = 2;
            this.lblClaveT.Text = "Clave Tabla";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(23, 35);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(54, 22);
            this.txtClave.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(30, 19);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 75);
            this.textBox1.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(119, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion ";
            this.lblDescripcion.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(594, 312);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(546, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(42, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(495, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 120);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 74);
            this.textBox2.TabIndex = 17;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 361);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblClaveT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblClaveS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblClaveT;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}