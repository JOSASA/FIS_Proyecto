using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace PROYECTO.Forms
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void CerrarSesion()
        {
            Business.Usuarios mUsuarios = new Business.Usuarios();
            string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET EstadoSesion = 'Cerrado' WHERE Usuario = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añadir parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("@Username", mUsuarios.usuario); // Reemplaza "usuarioActual" con el nombre de usuario actual

                    // Abrir la conexión y ejecutar la consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CerrarSesion(); 
        }
    }
}
