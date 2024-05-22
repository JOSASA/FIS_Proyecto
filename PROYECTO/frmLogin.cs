using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;

namespace PROYECTO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                //Poder validar datos vs BD vs fileEncrypt
                Business.Usuarios mUsuarios = new Business.Usuarios();
                mUsuarios.pwd = txtPassword.Text;
                mUsuarios.usuario = txtUsuario.Text;

                if (mUsuarios.fnValidaLogin())
                {
                    DateTime dateTime = DateTime.Now;
                    Utilerias.G_LoginTime = dateTime;
                    ConexionSQL conn = new ConexionSQL();
                    conn.AbrirConexion();
                    string insertQuery = "INSERT INTO LoginHistory (Username, LoginTime) VALUES (@Username, @LoginTime)";
                    using (SqlCommand command = new SqlCommand(insertQuery, conn.AbrirConexion()))
                    {
                        conn.AbrirConexion();

                        // Insertar el registro de inicio de sesión en la base de datos
                        command.Parameters.AddWithValue("@Username", mUsuarios.usuario);
                        command.Parameters.AddWithValue("@LoginTime", dateTime);
                        command.ExecuteNonQuery();
                    }
                    conn.CerrarConexion();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No es valido el usuario o contraseña", "Aviso POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[btnIngresar_Click] " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            //Se muestra la contraseña
            txtPassword.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            //Se oculta la contraseña
            txtPassword.PasswordChar = '*';
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al evento Click del botón de inicio de sesión
                btnIngresar.PerformClick();
            }
        }


    }
}
