using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO.Forms
{
    partial class frmProveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevoProveedor = new System.Windows.Forms.Button();
            this.DGproveedores = new System.Windows.Forms.DataGridView();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxRepresentante = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.buttonNuevoProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 28);
            this.panel1.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(328, 0);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(144, 28);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar Proveedor";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(168, 0);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(144, 28);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar proveedor";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(490, 0);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(144, 28);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevoProveedor
            // 
            this.buttonNuevoProveedor.Location = new System.Drawing.Point(0, 0);
            this.buttonNuevoProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNuevoProveedor.Name = "buttonNuevoProveedor";
            this.buttonNuevoProveedor.Size = new System.Drawing.Size(144, 28);
            this.buttonNuevoProveedor.TabIndex = 0;
            this.buttonNuevoProveedor.Text = "Nuevo Proveedor";
            this.buttonNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevoProveedor.UseVisualStyleBackColor = true;
            this.buttonNuevoProveedor.Click += new System.EventHandler(this.buttonNuevoProveedor_Click);
            // 
            // DGproveedores
            // 
            this.DGproveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGproveedores.Location = new System.Drawing.Point(0, 56);
            this.DGproveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGproveedores.Name = "DGproveedores";
            this.DGproveedores.RowHeadersWidth = 51;
            this.DGproveedores.Size = new System.Drawing.Size(568, 429);
            this.DGproveedores.TabIndex = 1;
            this.DGproveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGproveedores_CellContentClick);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(650, 81);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumero.TabIndex = 2;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(650, 114);
            this.textBoxEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(76, 20);
            this.textBoxEmpresa.TabIndex = 3;
            // 
            // textBoxRepresentante
            // 
            this.textBoxRepresentante.Location = new System.Drawing.Point(650, 145);
            this.textBoxRepresentante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRepresentante.Name = "textBoxRepresentante";
            this.textBoxRepresentante.Size = new System.Drawing.Size(76, 20);
            this.textBoxRepresentante.TabIndex = 4;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(650, 177);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(76, 20);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(650, 210);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(76, 20);
            this.textBoxCorreo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Representante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "correo";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxRepresentante);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.DGproveedores);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProveedores";
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView DGproveedores;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonNuevoProveedor;
        private Button buttonModificar;
        private TextBox textBoxNumero;
        private TextBox textBoxEmpresa;
        private TextBox textBoxRepresentante;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}