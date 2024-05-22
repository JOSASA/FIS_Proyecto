using impresionTicket;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business;
using System.Threading.Tasks;
using Data;
using System.Collections.Generic;

namespace PROYECTO.Forms
{
    public partial class frmVentas : Form
    {
        private ConexionSQL conexion;
        private string nombreProducto;
        private string precioVenta;
        private string hay;
        private crearTicket ticket;
       public double total
        {
            get; set;
        }
        public frmVentas()
        {
            InitializeComponent();
            conexion = new ConexionSQL();
            ticket = new crearTicket();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView
            DGproductos.Columns.Add("Codigo", "Codigo");
            DGproductos.Columns.Add("Descripcion", "Descripcion");
            DGproductos.Columns.Add("PrecioVenta", "Precio Venta");
            DGproductos.Columns.Add("Cantidad", "Cantidad");
            DGproductos.Columns.Add("Subtotal", "Subtotal");

            DGproductos.Columns["Cantidad"].ReadOnly = false;
            DGproductos.Columns["Codigo"].ReadOnly = true;
            DGproductos.Columns["Descripcion"].ReadOnly = true;
            DGproductos.Columns["PrecioVenta"].ReadOnly = true;
            DGproductos.Columns["Subtotal"].ReadOnly = true;

            DGproductos.CellEndEdit += DGproductos_CellEndEdit;

            
        }


        private void DGproductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DGproductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                try
                {
                    int nuevaCantidad = Convert.ToInt32(DGproductos.Rows[e.RowIndex].Cells["Cantidad"].Value);

                    if (nuevaCantidad > 0)
                    {
                        double precioVenta = Convert.ToDouble(DGproductos.Rows[e.RowIndex].Cells["PrecioVenta"].Value);
                        double nuevoSubtotal = nuevaCantidad * precioVenta;
                        DGproductos.Rows[e.RowIndex].Cells["Subtotal"].Value = nuevoSubtotal;
                        RecalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a cero.");
                        DGproductos.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                        RecalcularSubtotal(e.RowIndex);
                        RecalcularTotal();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                    DGproductos.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;
                    RecalcularSubtotal(e.RowIndex);
                    RecalcularTotal();
                }
            }
        }

        private void RecalcularSubtotal(int rowIndex)
        {
            int cantidad = Convert.ToInt32(DGproductos.Rows[rowIndex].Cells["Cantidad"].Value);
            double precioVenta = Convert.ToDouble(DGproductos.Rows[rowIndex].Cells["PrecioVenta"].Value);
            double subtotal = cantidad * precioVenta;
            DGproductos.Rows[rowIndex].Cells["Subtotal"].Value = subtotal;
        }

        private void RecalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in DGproductos.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["Subtotal"].Value);
                }
            }
            labelTotal.Text = "Total: " + total.ToString("0.00");
        }

        public void crear(string pdfPath)
        {
            ticket.empresa = labelEmpresa.Text;
            ticket.direccion = labelDireccion.Text;
            ticket.telefono = labelTelefono.Text;
            ticket.logotipo = pictureBox1.Image;
            ticket.listaProductos.Clear();

            for (int i = 0; i < DGproductos.Rows.Count - 1; i++)
            {
                productos p = new productos
                {
                    codigo = Convert.ToString(DGproductos.Rows[i].Cells[0].Value),
                    descripcion = Convert.ToString(DGproductos.Rows[i].Cells[1].Value),
                    precioVenta = Convert.ToDouble(DGproductos.Rows[i].Cells[2].Value),
                    cantidad = Convert.ToInt32(DGproductos.Rows[i].Cells[3].Value),
                    subtotal = Convert.ToDouble(DGproductos.Rows[i].Cells[4].Value)
                };
                ticket.listaProductos.Add(p);
            }

            ticket.total = (decimal)total;
            ticket.CrearPDF(pdfPath);
        }

        
        private void EliminarArchivo(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el archivo temporal: {ex.Message}");
            }
        }

        public void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();
            productos p = new productos();
            String codigoProducto = textBoxCodigo.Text;
            int length = codigoProducto.Length;
            labelLenght.Text = Convert.ToString(length);
            conn.AbrirConexion();

            if (textBoxCodigo.Text.Length == 4)
            {
                try
                {
                    string selectQuery = "SELECT * FROM Productos WHERE codigoProducto = @codigoProducto";
                    SqlCommand command = new SqlCommand(selectQuery, conexion.AbrirConexion());
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                    SqlDataReader result = command.ExecuteReader();
                    if (result.Read())
                    {
                        hay = result["hay"].ToString();
                        result.Close();
                        conn.CerrarConexion();
                    }
                    if (Convert.ToInt16(hay) <= 0) {
                        MessageBox.Show("No hay suficiente Stock");
                        
                    } else
                    {
                        
                        AgregarProductoPorCodigo(textBoxCodigo.Text);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private void agregarAventas(string usuario, double totalVenta, DateTime fechaVenta, string productosVendidos)
        {
            ConexionSQL conn = new ConexionSQL();
            try
            {
                conexion.AbrirConexion();
                string selectQuery = "Insert into Ventas(Usuario,totalVenta,fechaVenta,productosVendidos) values (@Usuario, @totalVenta, @fechaVenta, @productosVendidos)";
                SqlCommand command = new SqlCommand(selectQuery, conexion.AbrirConexion());
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@totalVenta", totalVenta);
                command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                command.Parameters.AddWithValue("@productosVendidos", productosVendidos);

                SqlDataReader result = command.ExecuteReader();
                if (result.Read())
                {
                }

                result.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar a reporte ventas: {ex.Message}");
            }
        }
        private void AgregarProductoPorCodigo(string codigoProducto)
        {
            ConexionSQL conn = new ConexionSQL();
            try
            {
                conexion.AbrirConexion();
                string selectQuery = "SELECT * FROM Productos WHERE codigoProducto = @codigoProducto";
                SqlCommand command = new SqlCommand(selectQuery, conexion.AbrirConexion());
                command.Parameters.AddWithValue("@codigoProducto", codigoProducto);

                SqlDataReader result = command.ExecuteReader();
                if (result.Read())
                {
                    nombreProducto = result["descripcion"].ToString();
                    precioVenta = result["precioVenta"].ToString();

                    DGproductos.Rows.Add(codigoProducto, nombreProducto, precioVenta, 1, Convert.ToDouble(precioVenta));
                    textBoxCodigo.Clear();
                    total += Convert.ToDouble(precioVenta);
                    labelTotal.Text = "Total: " + total.ToString("0.00");
                }

                result.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch("Productos", "codigo");
            frmSearch.ProductoSeleccionado += FrmSearch_ProductoSeleccionado; // Suscribir al evento
            frmSearch.ShowDialog();
        }

        private void FrmSearch_ProductoSeleccionado(productos producto)
        {
            // Lógica para agregar el producto seleccionado al DataGridView
            DGproductos.Rows.Add(producto.codigo, producto.descripcion, producto.precioVenta, 1, producto.precioVenta);
            total += producto.precioVenta;
            labelTotal.Text = "Total: " + total.ToString("0.00");
        }

        public void cambioTextBox(string cambio)
        {
            textBoxCodigo.Text = cambio;
        }


        // Método para actualizar el stock después de una venta
        private void ActualizarStockDespuesVenta()
        {
            foreach (DataGridViewRow row in DGproductos.Rows)
            {
                if (row.Cells["Codigo"].Value != null)
                {
                    string codigoProducto = row.Cells["Codigo"].Value.ToString();
                    int cantidadVendida = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    try
                    {
                        conexion.AbrirConexion();
                        conexion.ActualizarStock(codigoProducto, cantidadVendida);
                        conexion.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar el stock: {ex.Message}");
                    }
                }
            }
        }

        // Modificar el método de impresión para actualizar el stock después de la venta
        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Path.GetTempPath(), "ticket.pdf");
            crear(pdfPath); 

            if (radioButtonEnviar.Checked)
            {
                Enviar_correo.FormSendMail formSendMail = new Enviar_correo.FormSendMail(pdfPath); // Pasar la ruta del PDF al formulario
                formSendMail.ShowDialog();

                formSendMail.FormClosed += (s, args) =>
                {
                    EliminarArchivo(pdfPath);
                };
            }
            else if (radioButtonImprimir.Checked)
            {
                ticket.imprimir();

                // Actualizar el stock después de imprimir el ticket
                ActualizarStockDespuesVenta();

                // Esperar unos segundos antes de intentar eliminar el archivo
                await Task.Delay(5000); // Esperar 5 segundos (ajustar el tiempo según sea necesario)

                EliminarArchivo(pdfPath);
                DateTime dateTime = DateTime.Now;
                agregarAventas(Utilerias.G_Usuario, total, dateTime, "String");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DGproductos.CurrentRow != null)
            { 
                    DGproductos.Rows.RemoveAt(DGproductos.CurrentRow.Index);
                    RecalcularTotal();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }
    }
}
