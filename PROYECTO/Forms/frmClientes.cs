using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace PROYECTO.Forms
{
    public partial class frmClientes : Form
    {
        ConexionSQL conexionSQL = new ConexionSQL();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvTablaClientes.DataSource = conexionSQL.ObtenerClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCliente())
            {
                int idCliente;
                if (int.TryParse(txtIdCliente.Text, out idCliente))
                {
                    string nombre = txtNombre.Text.Trim();
                    string apellido = txtApellido.Text.Trim();
                    string telefono = txtTelefono.Text.Trim();
                    string correo = txtCorreo.Text.Trim();

                    if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(correo))
                    {
                        ConexionSQL conexionSQL = new ConexionSQL();
                        if (conexionSQL.AgregarCliente(idCliente, nombre, apellido, telefono, correo))
                        {
                            MessageBox.Show("Cliente agregado correctamente.");
                            LimpiarCampos();
                            dgvTablaClientes.DataSource = conexionSQL.ObtenerClientes();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar cliente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del cliente debe ser un número entero.");
                }
            }
        }
        private bool ValidarDatosCliente()
        {
            // Validar correo electrónico
            if (!txtCorreo.Text.Trim().EndsWith("@gmail.com"))
            {
                MessageBox.Show("El correo electrónico debe terminar con '@gmail.com'.");
                return false;
            }

            // Validar longitud del teléfono
            if (txtTelefono.Text.Trim().Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
