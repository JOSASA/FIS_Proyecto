namespace ProyFIS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            button1 = new Button();
            btnajustes = new Button();
            btnmp = new Button();
            btninve = new Button();
            btnslide = new PictureBox();
            btnventa = new Button();
            btncliente = new Button();
            btnpedido = new Button();
            btnprov = new Button();
            BarraTitulo = new Panel();
            iconminimizar = new PictureBox();
            iconrestaurar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnslide).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 122, 204);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(btnajustes);
            MenuVertical.Controls.Add(btnmp);
            MenuVertical.Controls.Add(btninve);
            MenuVertical.Controls.Add(btnslide);
            MenuVertical.Controls.Add(btnventa);
            MenuVertical.Controls.Add(btncliente);
            MenuVertical.Controls.Add(btnpedido);
            MenuVertical.Controls.Add(btnprov);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            MenuVertical.MouseDown += MenuVertical_MouseDown;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 103);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 2;
            button1.Text = "                 Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnajustes
            // 
            btnajustes.FlatAppearance.BorderSize = 0;
            btnajustes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnajustes.FlatStyle = FlatStyle.Flat;
            btnajustes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnajustes.ForeColor = Color.White;
            btnajustes.Image = (Image)resources.GetObject("btnajustes.Image");
            btnajustes.ImageAlign = ContentAlignment.MiddleLeft;
            btnajustes.Location = new Point(0, 425);
            btnajustes.Name = "btnajustes";
            btnajustes.Size = new Size(250, 40);
            btnajustes.TabIndex = 1;
            btnajustes.Text = "                 Setting";
            btnajustes.TextAlign = ContentAlignment.MiddleLeft;
            btnajustes.UseVisualStyleBackColor = true;
            // 
            // btnmp
            // 
            btnmp.FlatAppearance.BorderSize = 0;
            btnmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnmp.FlatStyle = FlatStyle.Flat;
            btnmp.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmp.ForeColor = Color.White;
            btnmp.Image = (Image)resources.GetObject("btnmp.Image");
            btnmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnmp.Location = new Point(0, 379);
            btnmp.Name = "btnmp";
            btnmp.Size = new Size(250, 40);
            btnmp.TabIndex = 5;
            btnmp.Text = "                 Metodo de Pago";
            btnmp.TextAlign = ContentAlignment.MiddleLeft;
            btnmp.UseVisualStyleBackColor = true;
            // 
            // btninve
            // 
            btninve.FlatAppearance.BorderSize = 0;
            btninve.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btninve.FlatStyle = FlatStyle.Flat;
            btninve.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninve.ForeColor = Color.White;
            btninve.Image = (Image)resources.GetObject("btninve.Image");
            btninve.ImageAlign = ContentAlignment.MiddleLeft;
            btninve.Location = new Point(0, 333);
            btninve.Name = "btninve";
            btninve.Size = new Size(250, 40);
            btninve.TabIndex = 4;
            btninve.Text = "                 Inventario";
            btninve.TextAlign = ContentAlignment.MiddleLeft;
            btninve.UseVisualStyleBackColor = true;
            // 
            // btnslide
            // 
            btnslide.Cursor = Cursors.Hand;
            btnslide.Image = (Image)resources.GetObject("btnslide.Image");
            btnslide.Location = new Point(12, 10);
            btnslide.Name = "btnslide";
            btnslide.Size = new Size(40, 40);
            btnslide.SizeMode = PictureBoxSizeMode.Zoom;
            btnslide.TabIndex = 0;
            btnslide.TabStop = false;
            btnslide.Click += btnslide_Click;
            // 
            // btnventa
            // 
            btnventa.FlatAppearance.BorderSize = 0;
            btnventa.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnventa.FlatStyle = FlatStyle.Flat;
            btnventa.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventa.ForeColor = Color.White;
            btnventa.Image = (Image)resources.GetObject("btnventa.Image");
            btnventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnventa.Location = new Point(0, 287);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(250, 40);
            btnventa.TabIndex = 3;
            btnventa.Text = "                 Ventas";
            btnventa.TextAlign = ContentAlignment.MiddleLeft;
            btnventa.UseVisualStyleBackColor = true;
            // 
            // btncliente
            // 
            btncliente.FlatAppearance.BorderSize = 0;
            btncliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btncliente.FlatStyle = FlatStyle.Flat;
            btncliente.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncliente.ForeColor = Color.White;
            btncliente.Image = (Image)resources.GetObject("btncliente.Image");
            btncliente.ImageAlign = ContentAlignment.MiddleLeft;
            btncliente.Location = new Point(0, 241);
            btncliente.Name = "btncliente";
            btncliente.Size = new Size(250, 40);
            btncliente.TabIndex = 2;
            btncliente.Text = "                 Clientes";
            btncliente.TextAlign = ContentAlignment.MiddleLeft;
            btncliente.UseVisualStyleBackColor = true;
            // 
            // btnpedido
            // 
            btnpedido.FlatAppearance.BorderSize = 0;
            btnpedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnpedido.FlatStyle = FlatStyle.Flat;
            btnpedido.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpedido.ForeColor = Color.White;
            btnpedido.Image = (Image)resources.GetObject("btnpedido.Image");
            btnpedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnpedido.Location = new Point(0, 195);
            btnpedido.Name = "btnpedido";
            btnpedido.Size = new Size(250, 40);
            btnpedido.TabIndex = 1;
            btnpedido.Text = "                 Pedidos";
            btnpedido.TextAlign = ContentAlignment.MiddleLeft;
            btnpedido.UseVisualStyleBackColor = true;
            // 
            // btnprov
            // 
            btnprov.FlatAppearance.BorderSize = 0;
            btnprov.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprov.FlatStyle = FlatStyle.Flat;
            btnprov.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprov.ForeColor = Color.White;
            btnprov.Image = (Image)resources.GetObject("btnprov.Image");
            btnprov.ImageAlign = ContentAlignment.MiddleLeft;
            btnprov.Location = new Point(0, 149);
            btnprov.Name = "btnprov";
            btnprov.Size = new Size(250, 40);
            btnprov.TabIndex = 0;
            btnprov.Text = "Proveedores";
            btnprov.UseVisualStyleBackColor = true;
            btnprov.Click += btnprov_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.WhiteSmoke;
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconrestaurar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1050, 50);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Image = (Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new Point(973, 6);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(20, 20);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 4;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Cursor = Cursors.Hand;
            iconrestaurar.Image = (Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new Point(999, 6);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(20, 20);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 3;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Image = (Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new Point(999, 5);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(20, 20);
            iconmaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Image = (Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new Point(1025, 5);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(20, 20);
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gainsboro;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1050, 600);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnslide).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private PictureBox btnslide;
        private Panel panelContenedor;
        private PictureBox iconminimizar;
        private PictureBox iconrestaurar;
        private PictureBox iconmaximizar;
        private PictureBox iconcerrar;
        private Button btnprov;
        private Button btnajustes;
        private Button btnmp;
        private Button btninve;
        private Button btnventa;
        private Button btncliente;
        private Button btnpedido;
        private Button button1;
    }
}
