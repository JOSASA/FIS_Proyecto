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

namespace PROYECTO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                    //ingresa en el sistema
                    //los permisos del usuario que hizo login 
                    string nombreServidor = "PC-DAVID-BAUDEL\\BAUDELIO_M_V";
                    string nombreBD = "ABARROTECONCHA";
                    string usuarioBD = "Pruebas";
                    string passwordBD = "12345";
                    string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBD};User ID={usuarioBD};Password={passwordBD};";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Insertar el registro de inicio de sesión en la base de datos
                        string insertQuery = "INSERT INTO LoginHistory (Username, LoginTime) VALUES (@Username, @LoginTime)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@Username", mUsuarios.usuario);
                        command.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

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
    }
}
