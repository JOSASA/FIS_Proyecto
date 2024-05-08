namespace PROYECTO.Forms
{
    partial class frmCompras
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
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnAgregarCarro = new System.Windows.Forms.Button();
            this.lstCarro = new System.Windows.Forms.ListBox();
            this.cmbCompras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(581, 151);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.Size = new System.Drawing.Size(453, 185);
            this.dgvCompra.TabIndex = 0;
            // 
            // btnAgregarCarro
            // 
            this.btnAgregarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarro.Location = new System.Drawing.Point(397, 151);
            this.btnAgregarCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCarro.Name = "btnAgregarCarro";
            this.btnAgregarCarro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarCarro.Size = new System.Drawing.Size(157, 28);
            this.btnAgregarCarro.TabIndex = 1;
            this.btnAgregarCarro.Text = "Agregar al carrito";
            this.btnAgregarCarro.UseVisualStyleBackColor = true;
            this.btnAgregarCarro.Click += new System.EventHandler(this.btnAgregarCarro_Click);
            // 
            // lstCarro
            // 
            this.lstCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarro.FormattingEnabled = true;
            this.lstCarro.ItemHeight = 17;
            this.lstCarro.Location = new System.Drawing.Point(397, 219);
            this.lstCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCarro.Name = "lstCarro";
            this.lstCarro.Size = new System.Drawing.Size(156, 106);
            this.lstCarro.TabIndex = 3;
            // 
            // cmbCompras
            // 
            this.cmbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompras.FormattingEnabled = true;
            this.cmbCompras.Location = new System.Drawing.Point(207, 151);
            this.cmbCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCompras.Name = "cmbCompras";
            this.cmbCompras.Size = new System.Drawing.Size(160, 25);
            this.cmbCompras.TabIndex = 4;
            this.cmbCompras.SelectedIndexChanged += new System.EventHandler(this.cmbCompras_SelectedIndexChanged);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbCompras);
            this.Controls.Add(this.lstCarro);
            this.Controls.Add(this.btnAgregarCarro);
            this.Controls.Add(this.dgvCompra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Button btnAgregarCarro;
        private System.Windows.Forms.ListBox lstCarro;
        private System.Windows.Forms.ComboBox cmbCompras;
    }
}