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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(224, 163);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(550, 150);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.Location = new System.Drawing.Point(224, 90);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoStock.TabIndex = 2;
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarStock.Location = new System.Drawing.Point(399, 90);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(75, 38);
            this.btnActualizarStock.TabIndex = 3;
            this.btnActualizarStock.Text = "Actualizar Stock";
            this.btnActualizarStock.UseVisualStyleBackColor = true;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarStock);
            this.Controls.Add(this.txtNuevoStock);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.Button btnActualizarStock;
    }
}