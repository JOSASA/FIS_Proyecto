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
using Data;
using impresionTicket;

namespace PROYECTO.Forms
{
    public partial class frmProveedores : Form
    {
        ConexionSQL ConexionSQL = new ConexionSQL();
        public frmProveedores()
        {
            InitializeComponent();
            textBoxNumero.Enabled = false;
            textBoxEmpresa.Enabled = false;
            textBoxTelefono.Enabled = false;
            textBoxRepresentante.Enabled = false;
            textBoxCorreo.Enabled = false;
            buttonGuardar.Enabled = false;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            DGproveedores.DataSource = ConexionSQL.ObtenerProveedor(); 
        }

        private void buttonNuevoProveedor_Click(object sender, EventArgs e)
        {
            textBoxNumero.Enabled = true;
            textBoxEmpresa.Enabled = true;
            textBoxTelefono.Enabled = true;
            textBoxRepresentante.Enabled = true;
            textBoxCorreo.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();

            try
            {
                conn.AbrirConexion();
                string insertQuery = "INSERT INTO Proveedores (numero, nombre, representante, telefono, correo) VALUES (@numero, @nombre, @representante, @telefono, @correo);";

                // Crear y ejecutar el comando SQL
                using (SqlCommand command = new SqlCommand(insertQuery, conn.AbrirConexion()))
                {
                    command.Parameters.AddWithValue("@numero", Convert.ToInt64(textBoxNumero.Text)); // Acceder a la propiedad Text
                    command.Parameters.AddWithValue("@nombre", textBoxEmpresa.Text);
                    command.Parameters.AddWithValue("@representante", textBoxRepresentante.Text); // Acceder a la propiedad Text
                    command.Parameters.AddWithValue("@telefono", Convert.ToInt64(textBoxTelefono.Text)); // Acceder a la propiedad Text
                    command.Parameters.AddWithValue("@correo", textBoxCorreo.Text);

                    command.ExecuteNonQuery();
                }

                // Actualizar el DataGridView con los datos de los proveedores
                DGproveedores.DataSource = ConexionSQL.ObtenerProveedor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                // Cerrar la conexión
                conn.CerrarConexion();
            }
        }

    }
}
