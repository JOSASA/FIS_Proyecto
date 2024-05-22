using System;
using System.Data;
using System.Windows.Forms;
using Data;
using impresionTicket;

namespace PROYECTO.Forms
{
    public partial class frmSearch : Form
    {
        private string tableName;
        private ConexionSQL conn;
        private string referencia;

        public event Action<productos> ProductoSeleccionado;

        public frmSearch(string nombretabla, string referencia)
        {
            InitializeComponent();
            conn = new ConexionSQL();
            this.tableName = nombretabla;
            this.referencia = referencia;
            dataGridView1.DataSource = conn.ObtenerDatosTabla(nombretabla);
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscador.Text.Trim();
            if (!string.IsNullOrEmpty(textoBusqueda) && !string.IsNullOrEmpty(tableName))
            {
                DataTable resultados = conn.buscarCoincidencias(textoBusqueda, tableName, referencia);
                MostrarResultados(resultados);
            }
            else
            {
                dataGridView1.DataSource = conn.ObtenerDatosTabla(tableName);
            }
        }

        private void MostrarResultados(DataTable resultados)
        {
            dataGridView1.DataSource = resultados;
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedRow = dataGridView1.CurrentRow;
                productos producto = new productos
                {
                    codigo = selectedRow.Cells["CodigoProducto"].Value.ToString(),
                    descripcion = selectedRow.Cells["Descripcion"].Value.ToString(),
                    precioVenta = Convert.ToDouble(selectedRow.Cells["PrecioVenta"].Value),
                };

                // Disparar el evento con los datos del producto seleccionado
                ProductoSeleccionado?.Invoke(producto);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto.");
            }
        }
    }
}
