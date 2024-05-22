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
            btnActualizarStock.Click += new EventHandler(btnActualizarStock_Click);
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CargarProductosConStockBajo();
        }
        

        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarProductosConStockBajo()
        {
            dgvProductos.DataSource = conexionSQL.ObtenerProductosConStockBajo();
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            

            if (dgvProductos.SelectedRows.Count > 0)
            {
                string codigoProducto = dgvProductos.SelectedRows[0].Cells["codigoProducto"].Value.ToString();
                int nuevoStock;

                if (int.TryParse(txtNuevoStock.Text, out nuevoStock))
                {
                    if (conexionSQL.ActualizarStockProducto(codigoProducto, nuevoStock))
                    {
                        MessageBox.Show(this, "Stock actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cargar los productos con stock bajo después de mostrar el mensaje de éxito
                        CargarProductosConStockBajo();
                        txtNuevoStock.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el stock.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el nuevo stock.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.");
            }

            // Vuelve a habilitar el botón después de terminar el procesamiento
            btnActualizarStock.Enabled = true;
        }
        
    }
}
