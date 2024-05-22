namespace PROYECTO.Forms
{
    partial class frmReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGventas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DGcompras = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalVentas = new System.Windows.Forms.Label();
            this.labelTotalCompras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGanancias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // DGventas
            // 
            this.DGventas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGventas.Location = new System.Drawing.Point(42, 58);
            this.DGventas.Name = "DGventas";
            this.DGventas.RowHeadersWidth = 51;
            this.DGventas.RowTemplate.Height = 24;
            this.DGventas.Size = new System.Drawing.Size(968, 307);
            this.DGventas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compras";
            // 
            // DGcompras
            // 
            this.DGcompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGcompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcompras.Location = new System.Drawing.Point(47, 432);
            this.DGcompras.Name = "DGcompras";
            this.DGcompras.RowHeadersWidth = 51;
            this.DGcompras.RowTemplate.Height = 24;
            this.DGcompras.Size = new System.Drawing.Size(963, 301);
            this.DGcompras.TabIndex = 3;
            this.DGcompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBcompras_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1016, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Ventas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1019, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Compras";
            // 
            // labelTotalVentas
            // 
            this.labelTotalVentas.AutoSize = true;
            this.labelTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVentas.Location = new System.Drawing.Point(1020, 127);
            this.labelTotalVentas.Name = "labelTotalVentas";
            this.labelTotalVentas.Size = new System.Drawing.Size(58, 22);
            this.labelTotalVentas.TabIndex = 6;
            this.labelTotalVentas.Text = "label5";
            // 
            // labelTotalCompras
            // 
            this.labelTotalCompras.AutoSize = true;
            this.labelTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCompras.Location = new System.Drawing.Point(1020, 432);
            this.labelTotalCompras.Name = "labelTotalCompras";
            this.labelTotalCompras.Size = new System.Drawing.Size(53, 20);
            this.labelTotalCompras.TabIndex = 7;
            this.labelTotalCompras.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1021, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ganancias:";
            // 
            // labelGanancias
            // 
            this.labelGanancias.AutoSize = true;
            this.labelGanancias.Location = new System.Drawing.Point(1026, 652);
            this.labelGanancias.Name = "labelGanancias";
            this.labelGanancias.Size = new System.Drawing.Size(44, 16);
            this.labelGanancias.TabIndex = 9;
            this.labelGanancias.Text = "label6";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 805);
            this.Controls.Add(this.labelGanancias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalCompras);
            this.Controls.Add(this.labelTotalVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGcompras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGventas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGcompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGcompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalVentas;
        private System.Windows.Forms.Label labelTotalCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGanancias;
    }
}