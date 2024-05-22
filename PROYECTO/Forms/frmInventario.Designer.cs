using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO.Forms
{
    partial class frmInventario
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGproductos = new System.Windows.Forms.DataGridView();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.numUpDownPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaximo = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinimo = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHay = new System.Windows.Forms.NumericUpDown();
            this.labelMaximo = new System.Windows.Forms.Label();
            this.labelMinimo = new System.Windows.Forms.Label();
            this.labelHay = new System.Windows.Forms.Label();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.labelPrecioCosto = new System.Windows.Forms.Label();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.labelUnidadDeMedida = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevoProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecioCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGproductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 607);
            this.panel3.TabIndex = 46;
            // 
            // DGproductos
            // 
            this.DGproductos.BackgroundColor = System.Drawing.Color.White;
            this.DGproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGproductos.Location = new System.Drawing.Point(6, 95);
            this.DGproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGproductos.Name = "DGproductos";
            this.DGproductos.RowHeadersWidth = 51;
            this.DGproductos.Size = new System.Drawing.Size(955, 477);
            this.DGproductos.TabIndex = 0;
            this.DGproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(1280, 100);
            this.textBoxCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(150, 22);
            this.textBoxCodigoProducto.TabIndex = 45;
            this.textBoxCodigoProducto.TextChanged += new System.EventHandler(this.textBoxCodigoProducto_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(1279, 127);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(152, 22);
            this.textBoxDescripcion.TabIndex = 44;
            // 
            // comboBoxUnidadMedida
            // 
            this.comboBoxUnidadMedida.FormattingEnabled = true;
            this.comboBoxUnidadMedida.Location = new System.Drawing.Point(1280, 159);
            this.comboBoxUnidadMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUnidadMedida.Name = "comboBoxUnidadMedida";
            this.comboBoxUnidadMedida.Size = new System.Drawing.Size(151, 24);
            this.comboBoxUnidadMedida.TabIndex = 43;
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.FormattingEnabled = true;
            this.comboBoxUbicacion.Location = new System.Drawing.Point(1279, 186);
            this.comboBoxUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(151, 24);
            this.comboBoxUbicacion.TabIndex = 42;
            // 
            // numUpDownPrecioVenta
            // 
            this.numUpDownPrecioVenta.Location = new System.Drawing.Point(1280, 239);
            this.numUpDownPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownPrecioVenta.Name = "numUpDownPrecioVenta";
            this.numUpDownPrecioVenta.Size = new System.Drawing.Size(150, 22);
            this.numUpDownPrecioVenta.TabIndex = 41;
            // 
            // numUpDownPrecioCosto
            // 
            this.numUpDownPrecioCosto.Location = new System.Drawing.Point(1280, 213);
            this.numUpDownPrecioCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownPrecioCosto.Name = "numUpDownPrecioCosto";
            this.numUpDownPrecioCosto.Size = new System.Drawing.Size(150, 22);
            this.numUpDownPrecioCosto.TabIndex = 40;
            // 
            // numUpDownMaximo
            // 
            this.numUpDownMaximo.Location = new System.Drawing.Point(1280, 348);
            this.numUpDownMaximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownMaximo.Name = "numUpDownMaximo";
            this.numUpDownMaximo.Size = new System.Drawing.Size(150, 22);
            this.numUpDownMaximo.TabIndex = 39;
            // 
            // numUpDownMinimo
            // 
            this.numUpDownMinimo.Location = new System.Drawing.Point(1280, 322);
            this.numUpDownMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownMinimo.Name = "numUpDownMinimo";
            this.numUpDownMinimo.Size = new System.Drawing.Size(150, 22);
            this.numUpDownMinimo.TabIndex = 38;
            // 
            // numUpDownHay
            // 
            this.numUpDownHay.Location = new System.Drawing.Point(1280, 295);
            this.numUpDownHay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownHay.Name = "numUpDownHay";
            this.numUpDownHay.Size = new System.Drawing.Size(150, 22);
            this.numUpDownHay.TabIndex = 37;
            // 
            // labelMaximo
            // 
            this.labelMaximo.AutoSize = true;
            this.labelMaximo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaximo.Location = new System.Drawing.Point(1167, 347);
            this.labelMaximo.Name = "labelMaximo";
            this.labelMaximo.Size = new System.Drawing.Size(83, 28);
            this.labelMaximo.TabIndex = 36;
            this.labelMaximo.Text = "Máximo";
            // 
            // labelMinimo
            // 
            this.labelMinimo.AutoSize = true;
            this.labelMinimo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMinimo.Location = new System.Drawing.Point(1170, 318);
            this.labelMinimo.Name = "labelMinimo";
            this.labelMinimo.Size = new System.Drawing.Size(80, 28);
            this.labelMinimo.TabIndex = 35;
            this.labelMinimo.Text = "Mínimo";
            // 
            // labelHay
            // 
            this.labelHay.AutoSize = true;
            this.labelHay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHay.Location = new System.Drawing.Point(1204, 291);
            this.labelHay.Name = "labelHay";
            this.labelHay.Size = new System.Drawing.Size(46, 28);
            this.labelHay.TabIndex = 34;
            this.labelHay.Text = "Hay";
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPrecioVenta.Location = new System.Drawing.Point(1130, 242);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(120, 28);
            this.labelPrecioVenta.TabIndex = 33;
            this.labelPrecioVenta.Text = "Precio Venta";
            // 
            // labelPrecioCosto
            // 
            this.labelPrecioCosto.AutoSize = true;
            this.labelPrecioCosto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPrecioCosto.Location = new System.Drawing.Point(1128, 213);
            this.labelPrecioCosto.Name = "labelPrecioCosto";
            this.labelPrecioCosto.Size = new System.Drawing.Size(122, 28);
            this.labelPrecioCosto.TabIndex = 32;
            this.labelPrecioCosto.Text = "Precio Costo";
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUbicacion.Location = new System.Drawing.Point(1151, 184);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(99, 28);
            this.labelUbicacion.TabIndex = 31;
            this.labelUbicacion.Text = "Ubicación";
            // 
            // labelUnidadDeMedida
            // 
            this.labelUnidadDeMedida.AutoSize = true;
            this.labelUnidadDeMedida.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUnidadDeMedida.Location = new System.Drawing.Point(1075, 154);
            this.labelUnidadDeMedida.Name = "labelUnidadDeMedida";
            this.labelUnidadDeMedida.Size = new System.Drawing.Size(175, 28);
            this.labelUnidadDeMedida.TabIndex = 30;
            this.labelUnidadDeMedida.Text = "Unidad de Medida";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDescripcion.Location = new System.Drawing.Point(1136, 123);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(114, 28);
            this.labelDescripcion.TabIndex = 29;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCodigo.Location = new System.Drawing.Point(1060, 94);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(190, 28);
            this.labelCodigo.TabIndex = 28;
            this.labelCodigo.Text = "Codigo de Producto";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1296, 11);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(145, 34);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(1145, 11);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(145, 34);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevoProducto
            // 
            this.buttonNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevoProducto.Location = new System.Drawing.Point(994, 11);
            this.buttonNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNuevoProducto.Name = "buttonNuevoProducto";
            this.buttonNuevoProducto.Size = new System.Drawing.Size(145, 34);
            this.buttonNuevoProducto.TabIndex = 3;
            this.buttonNuevoProducto.Text = "Nuevo Producto";
            this.buttonNuevoProducto.UseVisualStyleBackColor = true;
            this.buttonNuevoProducto.Click += new System.EventHandler(this.buttonNuevoProducto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.buttonNuevoProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 62);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxCodigoProducto);
            this.panel2.Controls.Add(this.textBoxDescripcion);
            this.panel2.Controls.Add(this.comboBoxUnidadMedida);
            this.panel2.Controls.Add(this.comboBoxUbicacion);
            this.panel2.Controls.Add(this.numUpDownPrecioVenta);
            this.panel2.Controls.Add(this.numUpDownPrecioCosto);
            this.panel2.Controls.Add(this.numUpDownMaximo);
            this.panel2.Controls.Add(this.numUpDownMinimo);
            this.panel2.Controls.Add(this.numUpDownHay);
            this.panel2.Controls.Add(this.labelMaximo);
            this.panel2.Controls.Add(this.labelMinimo);
            this.panel2.Controls.Add(this.labelHay);
            this.panel2.Controls.Add(this.labelPrecioVenta);
            this.panel2.Controls.Add(this.labelPrecioCosto);
            this.panel2.Controls.Add(this.labelUbicacion);
            this.panel2.Controls.Add(this.labelUnidadDeMedida);
            this.panel2.Controls.Add(this.labelDescripcion);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1545, 607);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInventario";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrecioCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private TextBox textBoxCodigoProducto;
        private TextBox textBoxDescripcion;
        private ComboBox comboBoxUnidadMedida;
        private ComboBox comboBoxUbicacion;
        private NumericUpDown numUpDownPrecioVenta;
        private NumericUpDown numUpDownPrecioCosto;
        private NumericUpDown numUpDownMaximo;
        private NumericUpDown numUpDownMinimo;
        private NumericUpDown numUpDownHay;
        private Label labelMaximo;
        private Label labelMinimo;
        private Label labelHay;
        private Label labelPrecioVenta;
        private Label labelPrecioCosto;
        private Label labelUbicacion;
        private Label labelUnidadDeMedida;
        private Label labelDescripcion;
        private Label labelCodigo;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private Button buttonNuevoProducto;
        private Panel panel1;
        private Panel panel2;
        private DataGridView DGproductos;
    }
}