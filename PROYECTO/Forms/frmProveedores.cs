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
            // Habilitar campos para agregar un nuevo proveedor
            HabilitarCampos();
            OperacionPendiente = Operacion.Agregar;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OperacionPendiente == Operacion.Agregar)
                {
                    // Código para agregar proveedor
                }
                else if (OperacionPendiente == Operacion.Modificar)
                {
                    // Código para modificar proveedor
                }
                else if (OperacionPendiente == Operacion.Eliminar)
                {
                    // Eliminar proveedor
                    long numero = Convert.ToInt64(textBoxNumero.Text);

                    if (ConexionSQL.EliminarProveedor(numero))
                    {
                        MessageBox.Show("Proveedor eliminado exitosamente");
                        DGproveedores.DataSource = ConexionSQL.ObtenerProveedor(); // Actualizar el DataGridView
                        LimpiarCampos(); // Limpiar los campos del formulario
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar proveedor");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private enum Operacion
        {
            Agregar,
            Modificar,
            Eliminar
        }
        private Operacion OperacionPendiente;
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un registro para modificar
            if (DGproveedores.SelectedRows.Count > 0)
            {
                // Habilitar campos para modificar el proveedor seleccionado
                HabilitarCampos();
                OperacionPendiente = Operacion.Modificar;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para modificar.");
            }
        }

        private void DGproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica si se hizo clic en una fila válida
            {
                DataGridViewRow row = DGproveedores.Rows[e.RowIndex];
                textBoxNumero.Text = row.Cells["numero"].Value.ToString();
                textBoxEmpresa.Text = row.Cells["nombre"].Value.ToString();
                textBoxRepresentante.Text = row.Cells["representante"].Value.ToString();
                textBoxTelefono.Text = row.Cells["telefono"].Value.ToString();
                textBoxCorreo.Text = row.Cells["correo"].Value.ToString();

                // Habilitar la edición de campos al seleccionar un registro
                textBoxNumero.Enabled = true;
                textBoxEmpresa.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxRepresentante.Enabled = true;
                textBoxCorreo.Enabled = true;
                buttonGuardar.Enabled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un proveedor para eliminar
            if (DGproveedores.SelectedRows.Count > 0)
            {
                // Llenar los campos con la información del proveedor seleccionado
                LlenarCampos();

                // Deshabilitar la edición de campos
                DeshabilitarCampos();
                OperacionPendiente = Operacion.Eliminar;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.");
            }
        }
        private void LlenarCampos()
        {
            DataGridViewRow row = DGproveedores.SelectedRows[0];
            textBoxNumero.Text = row.Cells["numero"].Value.ToString();
            textBoxEmpresa.Text = row.Cells["nombre"].Value.ToString();
            textBoxRepresentante.Text = row.Cells["representante"].Value.ToString();
            textBoxTelefono.Text = row.Cells["telefono"].Value.ToString();
            textBoxCorreo.Text = row.Cells["correo"].Value.ToString();
        }

        private void HabilitarCampos()
        {
            textBoxNumero.Enabled = true;
            textBoxEmpresa.Enabled = true;
            textBoxTelefono.Enabled = true;
            textBoxRepresentante.Enabled = true;
            textBoxCorreo.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            textBoxNumero.Enabled = false;
            textBoxEmpresa.Enabled = false;
            textBoxTelefono.Enabled = false;
            textBoxRepresentante.Enabled = false;
            textBoxCorreo.Enabled = false;
            buttonGuardar.Enabled = true;
        }
        private void LimpiarCampos()
        {
            textBoxNumero.Text = "";
            textBoxEmpresa.Text = "";
            textBoxTelefono.Text = "";
            textBoxRepresentante.Text = "";
            textBoxCorreo.Text = "";
        }
    }
}
