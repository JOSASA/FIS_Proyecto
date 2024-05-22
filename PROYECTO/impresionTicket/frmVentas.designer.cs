namespace PROYECTO.Forms
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.DGproductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelLenght = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEnviar = new System.Windows.Forms.RadioButton();
            this.radioButtonImprimir = new System.Windows.Forms.RadioButton();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGproductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGproductos
            // 
            this.DGproductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGproductos.Location = new System.Drawing.Point(62, 249);
            this.DGproductos.Name = "DGproductos";
            this.DGproductos.RowHeadersWidth = 51;
            this.DGproductos.RowTemplate.Height = 24;
            this.DGproductos.Size = new System.Drawing.Size(678, 400);
            this.DGproductos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelLenght);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.DGproductos);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Controls.Add(this.textBoxCodigo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelTelefono);
            this.panel2.Controls.Add(this.labelDireccion);
            this.panel2.Controls.Add(this.labelEmpresa);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 813);
            this.panel2.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(617, 153);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(344, 176);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(14, 16);
            this.labelLenght.TabIndex = 10;
            this.labelLenght.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonEnviar);
            this.panel1.Controls.Add(this.radioButtonImprimir);
            this.panel1.Location = new System.Drawing.Point(892, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 91);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonEnviar
            // 
            this.radioButtonEnviar.AutoSize = true;
            this.radioButtonEnviar.Location = new System.Drawing.Point(23, 46);
            this.radioButtonEnviar.Name = "radioButtonEnviar";
            this.radioButtonEnviar.Size = new System.Drawing.Size(131, 20);
            this.radioButtonEnviar.TabIndex = 9;
            this.radioButtonEnviar.TabStop = true;
            this.radioButtonEnviar.Text = "Enviar por correo";
            this.radioButtonEnviar.UseVisualStyleBackColor = true;
            // 
            // radioButtonImprimir
            // 
            this.radioButtonImprimir.AutoSize = true;
            this.radioButtonImprimir.Location = new System.Drawing.Point(23, 20);
            this.radioButtonImprimir.Name = "radioButtonImprimir";
            this.radioButtonImprimir.Size = new System.Drawing.Size(75, 20);
            this.radioButtonImprimir.TabIndex = 8;
            this.radioButtonImprimir.TabStop = true;
            this.radioButtonImprimir.Text = "Imprimir";
            this.radioButtonImprimir.UseVisualStyleBackColor = true;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(150, 153);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(165, 20);
            this.labelCodigo.TabIndex = 7;
            this.labelCodigo.Text = "Código de barras: ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(347, 151);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(243, 22);
            this.textBoxCodigo.TabIndex = 6;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(238, 106);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(77, 16);
            this.labelTelefono.TabIndex = 4;
            this.labelTelefono.Text = "6627891020";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(238, 80);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(47, 16);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Av 324";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(238, 52);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(66, 16);
            this.labelEmpresa.TabIndex = 2;
            this.labelEmpresa.Text = "Abarrotes";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(892, 192);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 51);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Cobrar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(888, 46);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(63, 20);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(62, 192);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 33);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 808);
            this.Controls.Add(this.panel2);
            this.Name = "frmVentas";
            this.Text = "formVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGproductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGproductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonEnviar;
        private System.Windows.Forms.RadioButton radioButtonImprimir;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnEliminar;
    }
}