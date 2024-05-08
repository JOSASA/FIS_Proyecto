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
    public partial class frmCompras : Form
    {
        private ConexionSQL conexionSQL = new ConexionSQL();
        private List<string> carrito = new List<string>();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            dgvCompra.DataSource = conexionSQL.ObtenerCompra();
            CargarDatosEnComboBox();
        }
        private void CargarDatosEnComboBox()
        {
            try
            {
                DataTable dtCompras = conexionSQL.ObtenerCompra();
                if (dtCompras.Rows.Count > 0)
                {
                    cmbCompras.Items.Clear();
                    foreach (DataRow row in dtCompras.Rows)
                    {
                        string nombreProducto = row["Producto"].ToString();
                        cmbCompras.Items.Add(nombreProducto);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = cmbCompras.SelectedItem.ToString();
                carrito.Add(nombreProducto);
                MostrarProductosEnCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message);
            }
        }
        private void MostrarProductosEnCarrito()
        {
            lstCarro.Items.Clear();
            foreach (string producto in carrito)
            {
                lstCarro.Items.Add(producto);
            }
        }

        private void cmbCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
