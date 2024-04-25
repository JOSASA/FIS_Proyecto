namespace ProyFIS
{
    partial class MenuPrincipal2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal2));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnprov = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnajustes = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.lblDate);
            this.BarraTitulo.Controls.Add(this.labelNombre);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(188, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(926, 64);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(666, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 24);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "label2";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Image = global::FIS_Proyecto.Properties.Resources.icons8_usuario_24;
            this.labelNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.Location = new System.Drawing.Point(540, 42);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 24);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "label1";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click_1);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.BackColor = System.Drawing.Color.Black;
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Location = new System.Drawing.Point(852, 9);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(17, 16);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click_1);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.BackColor = System.Drawing.Color.Black;
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Location = new System.Drawing.Point(823, 9);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(17, 16);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click_1);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.Black;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Location = new System.Drawing.Point(896, 8);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(17, 16);
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(188, 64);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(926, 433);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnprov
            // 
            this.btnprov.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnprov.FlatAppearance.BorderSize = 0;
            this.btnprov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprov.ForeColor = System.Drawing.Color.White;
            this.btnprov.Image = ((System.Drawing.Image)(resources.GetObject("btnprov.Image")));
            this.btnprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprov.Location = new System.Drawing.Point(0, 224);
            this.btnprov.Name = "btnprov";
            this.btnprov.Size = new System.Drawing.Size(188, 42);
            this.btnprov.TabIndex = 0;
            this.btnprov.Text = "Proveedores";
            this.btnprov.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprov.UseVisualStyleBackColor = true;
            this.btnprov.Click += new System.EventHandler(this.btnprov_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::FIS_Proyecto.Properties.Resources.icons8_order_history_60;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 129);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(188, 42);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Pedidos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::FIS_Proyecto.Properties.Resources.icons8_customers_50;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 272);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(188, 42);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnventa
            // 
            this.btnventa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnventa.FlatAppearance.BorderSize = 0;
            this.btnventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.ForeColor = System.Drawing.Color.White;
            this.btnventa.Image = global::FIS_Proyecto.Properties.Resources.icons8_sales_501;
            this.btnventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventa.Location = new System.Drawing.Point(-3, 177);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(188, 42);
            this.btnventa.TabIndex = 3;
            this.btnventa.Text = "Ventas";
            this.btnventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Location = new System.Drawing.Point(0, 9);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(188, 55);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click_1);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = global::FIS_Proyecto.Properties.Resources.icons8_shopping_60;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 319);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(185, 42);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::FIS_Proyecto.Properties.Resources.icons8_users_60;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 367);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(185, 42);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnajustes
            // 
            this.btnajustes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnajustes.FlatAppearance.BorderSize = 0;
            this.btnajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajustes.ForeColor = System.Drawing.Color.White;
            this.btnajustes.Image = global::FIS_Proyecto.Properties.Resources.icons8_setting_50;
            this.btnajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajustes.Location = new System.Drawing.Point(0, 414);
            this.btnajustes.Name = "btnajustes";
            this.btnajustes.Size = new System.Drawing.Size(188, 42);
            this.btnajustes.TabIndex = 1;
            this.btnajustes.Text = "Configuracion";
            this.btnajustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnajustes.UseVisualStyleBackColor = true;
            this.btnajustes.Click += new System.EventHandler(this.btnajustes_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MenuVertical.Controls.Add(this.btnHome);
            this.MenuVertical.Controls.Add(this.btnajustes);
            this.MenuVertical.Controls.Add(this.btnUsers);
            this.MenuVertical.Controls.Add(this.btnCompras);
            this.MenuVertical.Controls.Add(this.btnslide);
            this.MenuVertical.Controls.Add(this.btnventa);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.btnprov);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(188, 497);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::FIS_Proyecto.Properties.Resources.icons8_home_60;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 81);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 42);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MenuPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 497);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal2";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel BarraTitulo;
        private Panel panelContenedor;
        private PictureBox iconminimizar;
        private PictureBox iconmaximizar;
        private PictureBox iconcerrar;
        private Button btnprov;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnventa;
        private PictureBox btnslide;
        private Button btnCompras;
        private Button btnUsers;
        private Button btnajustes;
        private Panel MenuVertical;
        private Button btnHome;
        private Label labelNombre;
        private Label lblDate;
    }
}
