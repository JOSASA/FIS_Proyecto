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
            CargarProductosBajoStock();
            CargarCompras();
        }
        private void CargarCompras()
        {
            dgvCompras.DataSource = conexionSQL.ObtenerCompras();
        }
        private void CargarProductosBajoStock()
        {
            dgvCompras.DataSource = conexionSQL.ObtenerProductosBajoStock();
        }

        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCompras.SelectedRows)
                {
                    string codigoProducto = row.Cells["codigoProducto"].Value.ToString();
                    string descripcion = row.Cells["descripcion"].Value.ToString();
                    string unidadMedida = row.Cells["unidadMedida"].Value.ToString();
                    string ubicacion = row.Cells["ubicacion"].Value.ToString();
                    decimal precioCosto = Convert.ToDecimal(row.Cells["precioCosto"].Value);
                    decimal precioVenta = Convert.ToDecimal(row.Cells["precioVenta"].Value);
                    int hayActual = Convert.ToInt32(row.Cells["hay"].Value);
                    int nuevoHay = hayActual + 20; // Agregar 20 unidades
                    int minimo = Convert.ToInt32(row.Cells["minimo"].Value);
                    int maximo = Convert.ToInt32(row.Cells["maximo"].Value);

                    conexionSQL.InsertarCompra(codigoProducto, descripcion, unidadMedida, ubicacion, precioCosto, precioVenta, nuevoHay, minimo, maximo);
                }
                CargarCompras();
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            conexionSQL.ConfirmarCompra();
            CargarProductosBajoStock();
            CargarCompras();
        }
    }
}
