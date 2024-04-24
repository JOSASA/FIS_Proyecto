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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal2));
            BarraTitulo = new Panel();
            labelNombre = new Label();
            iconminimizar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            panelContenedor = new Panel();
            btnprov = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnventa = new Button();
            btnslide = new PictureBox();
            btnCompras = new Button();
            btnUsers = new Button();
            btnajustes = new Button();
            MenuVertical = new Panel();
            btnHome = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).BeginInit();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.WhiteSmoke;
            BarraTitulo.Controls.Add(labelNombre);
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(219, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1081, 74);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(34, 27);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(65, 25);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "label1";
            labelNombre.Click += labelNombre_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.BackColor = Color.Black;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Location = new Point(995, 10);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(20, 18);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 4;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.BackColor = Color.Black;
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Location = new Point(961, 10);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(20, 18);
            iconmaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.BackColor = Color.Black;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Location = new Point(1046, 9);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(20, 18);
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gainsboro;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(219, 74);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1081, 500);
            panelContenedor.TabIndex = 2;
            // 
            // btnprov
            // 
            btnprov.FlatAppearance.BorderColor = Color.Black;
            btnprov.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprov.FlatStyle = FlatStyle.Flat;
            btnprov.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprov.ForeColor = Color.White;
            btnprov.Image = (Image)resources.GetObject("btnprov.Image");
            btnprov.ImageAlign = ContentAlignment.MiddleLeft;
            btnprov.Location = new Point(0, 259);
            btnprov.Name = "btnprov";
            btnprov.Size = new Size(219, 49);
            btnprov.TabIndex = 0;
            btnprov.Text = "Proveedores";
            btnprov.UseVisualStyleBackColor = true;
            btnprov.Click += btnprov_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderColor = Color.Black;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = FIS_Proyecto.Properties.Resources.icons8_order_history_60;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 149);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(219, 49);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Pedidos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderColor = Color.Black;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = FIS_Proyecto.Properties.Resources.icons8_customers_50;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 314);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(219, 49);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnventa
            // 
            btnventa.FlatAppearance.BorderColor = Color.Black;
            btnventa.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnventa.FlatStyle = FlatStyle.Flat;
            btnventa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventa.ForeColor = Color.White;
            btnventa.Image = FIS_Proyecto.Properties.Resources.icons8_sales_501;
            btnventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnventa.Location = new Point(-3, 204);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(219, 49);
            btnventa.TabIndex = 3;
            btnventa.Text = "Ventas";
            btnventa.UseVisualStyleBackColor = true;
            // 
            // btnslide
            // 
            btnslide.Cursor = Cursors.Hand;
            btnslide.Location = new Point(0, 10);
            btnslide.Name = "btnslide";
            btnslide.Size = new Size(219, 64);
            btnslide.SizeMode = PictureBoxSizeMode.Zoom;
            btnslide.TabIndex = 0;
            btnslide.TabStop = false;
            btnslide.Click += btnslide_Click;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderColor = Color.Black;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = FIS_Proyecto.Properties.Resources.icons8_shopping_60;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 368);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(216, 49);
            btnCompras.TabIndex = 4;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderColor = Color.Black;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = FIS_Proyecto.Properties.Resources.icons8_users_60;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 423);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(216, 49);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnajustes
            // 
            btnajustes.FlatAppearance.BorderColor = Color.Black;
            btnajustes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnajustes.FlatStyle = FlatStyle.Flat;
            btnajustes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnajustes.ForeColor = Color.White;
            btnajustes.Image = FIS_Proyecto.Properties.Resources.icons8_setting_50;
            btnajustes.ImageAlign = ContentAlignment.MiddleLeft;
            btnajustes.Location = new Point(0, 478);
            btnajustes.Name = "btnajustes";
            btnajustes.Size = new Size(219, 49);
            btnajustes.TabIndex = 1;
            btnajustes.Text = "Configuracion";
            btnajustes.UseVisualStyleBackColor = true;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(35, 40, 45);
            MenuVertical.Controls.Add(btnHome);
            MenuVertical.Controls.Add(btnajustes);
            MenuVertical.Controls.Add(btnUsers);
            MenuVertical.Controls.Add(btnCompras);
            MenuVertical.Controls.Add(btnslide);
            MenuVertical.Controls.Add(btnventa);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(btnprov);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(219, 574);
            MenuVertical.TabIndex = 0;
            MenuVertical.MouseDown += MenuVertical_MouseDown;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.Black;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = FIS_Proyecto.Properties.Resources.icons8_home_60;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 94);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(219, 49);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 574);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal2";
            Text = "Form1";
            Load += MenuPrincipal2_Load;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).EndInit();
            MenuVertical.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
