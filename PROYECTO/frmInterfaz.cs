﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using impresionTicket;
using PROYECTO.Forms;

namespace PROYECTO
{
    public partial class frmInterfaz : Form
    {
        private Form activeForm;
        public frmInterfaz()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            try
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                labelNombre.Text = ("   " + Business.Utilerias.G_Usuario);
                //lblDate.Text = DateTime.Now.ToString();
                lblDate.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[fmr_principal_Load] " + ex.Message);
            }
        }


        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Poder validar datos vs BD vs fileEncrypt
                Business.Usuarios mUsuarios = new Business.Usuarios();

                //ingresa en el sistema
                //los permisos del usuario que hizo login 
                String nombreServidor = "LEGION\\ALAN_O";
                String nombreBD = "ABARROTECONCHA";
                String usuarioBD = "admin";
                String passwordBD = "admin";
                string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBD};User ID={usuarioBD};Password={passwordBD};";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Insertar el registro de inicio de sesión en la base de datos
                        string insertQuery = "INSERT INTO LoginHistory (Username, LogoutTime) VALUES (@Username, @LogoutTime)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@Username", Business.Utilerias.G_Usuario);
                        command.Parameters.AddWithValue("@LogoutTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[iconcerrar_Click] " + ex.Message);
            }
        }

        private void frmInterfaz_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPedidos(), sender);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHome(), sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
                OpenChildForm(new frmVentas(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProveedores(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClientes(), sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCompras(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsuarios(), sender);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConfiguracion(), sender);
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
