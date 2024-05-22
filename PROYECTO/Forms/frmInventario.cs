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

namespace PROYECTO.Forms
{
    public partial class frmInventario : Form
    {
        ConexionSQL conexionSQL = new ConexionSQL();
        public frmInventario()
        {
            InitializeComponent();
            textBoxCodigoProducto.Enabled = false;
            textBoxDescripcion.Enabled = false;
            comboBoxUnidadMedida.Enabled = false;
            comboBoxUbicacion.Enabled = false;
            numUpDownPrecioCosto.Enabled = false;
            numUpDownPrecioVenta.Enabled = false;
            numUpDownHay.Enabled = false;
            numUpDownMinimo.Enabled = false;
            numUpDownMaximo.Enabled = false;
            buttonGuardar.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxCodigoProducto.Enabled = false;
            textBoxDescripcion.Enabled = false;
            comboBoxUnidadMedida.Enabled = false;
            comboBoxUbicacion.Enabled = false;
            numUpDownPrecioCosto.Enabled = false;
            numUpDownPrecioVenta.Enabled = false;
            numUpDownHay.Enabled = false;
            numUpDownMinimo.Enabled = false;
            numUpDownMaximo.Enabled = false;
            buttonGuardar.Enabled = false;
        }

        private void buttonNuevoProducto_Click(object sender, EventArgs e)
        {
            textBoxCodigoProducto.Enabled = true;
            textBoxDescripcion.Enabled = true;
            comboBoxUnidadMedida.Enabled = true;
            comboBoxUbicacion.Enabled = true;
            numUpDownPrecioCosto.Enabled = true;
            numUpDownPrecioVenta.Enabled = true;
            numUpDownHay.Enabled = true;
            numUpDownMinimo.Enabled = true;
            numUpDownMaximo.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoProducto = textBoxCodigoProducto.Text;
                string descripcion = textBoxDescripcion.Text;
                string unidadMedida = comboBoxUnidadMedida.Text;
                string ubicacion = comboBoxUbicacion.Text;
                decimal precioCosto = numUpDownPrecioCosto.Value;
                decimal precioVenta = numUpDownPrecioVenta.Value;
                int hay = (int)numUpDownHay.Value;
                int minimo = (int)numUpDownMinimo.Value;
                int maximo = (int)numUpDownMaximo.Value;

                if (conexionSQL.AgregarProducto(codigoProducto, descripcion, unidadMedida, ubicacion, precioCosto, precioVenta, hay, minimo, maximo))
                {
                    MessageBox.Show("Producto agregado exitosamente");
                    DGproductos.DataSource = conexionSQL.ObtenerProductos();
                }
                else
                {
                    MessageBox.Show("Error al agregar producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            DGproductos.DataSource = conexionSQL.ObtenerProductos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
