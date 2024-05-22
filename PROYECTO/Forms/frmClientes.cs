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
            CargarClientes();
        }
        private void CargarClientes()
        {
            dgvTablaClientes.DataSource = conexionSQL.ObtenerClientes();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (ValidarDatosCliente(nombre, apellido, telefono, correo))
            {
                if (conexionSQL.AgregarCliente(nombre, apellido, telefono, correo))
                {
                    MessageBox.Show("Cliente agregado correctamente.");
                    CargarClientes();
                    LimpiarCamposClientes();
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente.");
                }
            }
        }
        private bool ValidarDatosCliente(string nombre, string apellido, string telefono, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            if (!correo.EndsWith("@gmail.com"))
            {
                MessageBox.Show("El correo electrónico debe terminar con '@gmail.com'.");
                return false;
            }

            if (telefono.Length != 10 || !long.TryParse(telefono, out _))
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos.");
                return false;
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTablaClientes.Rows[e.RowIndex];
                txtIdCliente.Text = row.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (conexionSQL.EliminarCliente(idCliente))
                    {
                        MessageBox.Show("Cliente eliminado correctamente.");
                        CargarClientes();
                        LimpiarCamposClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.");
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correo = txtCorreo.Text.Trim();

                if (ValidarDatosCliente(nombre, apellido, telefono, correo))
                {
                    if (conexionSQL.ActualizarCliente(idCliente, nombre, apellido, telefono, correo))
                    {
                        MessageBox.Show("Cliente actualizado correctamente.");
                        CargarClientes();
                        LimpiarCamposClientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente.");
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCamposClientes()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
    }
}
