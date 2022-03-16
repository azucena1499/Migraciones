
namespace Migraciones.Forms
{
    partial class frmBusquedaConsulta
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgBusquedaConsulta = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Script = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtExpresion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 58);
            this.panel2.TabIndex = 23;
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
            this.btnCancelar.Location = new System.Drawing.Point(707, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(626, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgBusquedaConsulta
            // 
            this.dgBusquedaConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgBusquedaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBusquedaConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.idSistema,
            this.idTabla,
            this.descripcion,
            this.Script});
            this.dgBusquedaConsulta.Location = new System.Drawing.Point(0, 64);
            this.dgBusquedaConsulta.Name = "dgBusquedaConsulta";
            this.dgBusquedaConsulta.Size = new System.Drawing.Size(782, 208);
            this.dgBusquedaConsulta.TabIndex = 20;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.HeaderText = "Clave";
            this.cID.Name = "cID";
            // 
            // idSistema
            // 
            this.idSistema.DataPropertyName = "id_Sistema";
            this.idSistema.HeaderText = "Clave Sistema";
            this.idSistema.Name = "idSistema";
            this.idSistema.Width = 150;
            // 
            // idTabla
            // 
            this.idTabla.DataPropertyName = "id_Tabla";
            this.idTabla.HeaderText = "Tabla";
            this.idTabla.Name = "idTabla";
            this.idTabla.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 180;
            // 
            // Script
            // 
            this.Script.DataPropertyName = "script";
            this.Script.HeaderText = "Consulta";
            this.Script.Name = "Script";
            this.Script.Width = 150;
            // 
            // frmBusquedaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgBusquedaConsulta);
            this.Name = "frmBusquedaConsulta";
            this.Text = "frmBusquedaConsulta";
            this.Load += new System.EventHandler(this.frmBusquedaConsulta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataGridView dgBusquedaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Script;
    }
}