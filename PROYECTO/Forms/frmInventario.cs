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
            ConexionSQL conn = new ConexionSQL();
            
            try
            {
                conn.AbrirConexion();
                string insertQuery = "INSERT INTO Productos(codigoProducto, descripcion, unidadMedida, ubicacion, precioCosto, precioVenta, hay, minimo, maximo) VALUES(@codigoProducto, @descripcion, @unidadMedida, @ubicacion, @precioCosto, @precioVenta, @hay, @minimo, @maximo);";

                using (SqlCommand command = new SqlCommand(insertQuery, conn.AbrirConexion()))
                {
                    command.Parameters.AddWithValue("@codigoProducto", textBoxCodigoProducto.Text);
                    command.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
                    command.Parameters.AddWithValue("@unidadMedida", comboBoxUnidadMedida.Text);
                    command.Parameters.AddWithValue("@ubicacion", comboBoxUnidadMedida.Text);
                    command.Parameters.AddWithValue("@precioCosto", numUpDownPrecioCosto.Value);
                    command.Parameters.AddWithValue("@precioVenta", numUpDownPrecioVenta.Value);
                    command.Parameters.AddWithValue("@hay", numUpDownHay.Value);
                    command.Parameters.AddWithValue("@minimo", numUpDownMinimo.Value);
                    command.Parameters.AddWithValue("@maximo", numUpDownMaximo.Value);

                    command.ExecuteNonQuery();
                    textBoxCodigoProducto.Clear();
                    textBoxDescripcion.Clear();

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
                    DGproductos.DataSource = conexionSQL.ObtenerProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.CerrarConexion();
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
