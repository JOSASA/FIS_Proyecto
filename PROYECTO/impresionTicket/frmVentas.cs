using impresionTicket;
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
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using System.IO;

namespace PROYECTO.Forms
{
    public partial class frmVentas : Form
    {
        private ConexionSQL conexion;
        private string nombreProducto;
        private string precioVenta;
        private double total;

        public frmVentas()
        {
            InitializeComponent();
            conexion = new ConexionSQL();
        }
        public void crear(string pdfPath)
        {
            crearTicket ticket = new crearTicket
            {
                empresa = labelEmpresa.Text,
                direccion = labelDireccion.Text,
                telefono = labelTelefono.Text,
                logotipo = pictureBox1.Image
            };

            for (int i = 0; i < DGproductos.Rows.Count - 1; i++)
            {
                productos p = new productos
                {
                    codigo = Convert.ToString(DGproductos.Rows[i].Cells[0].Value),
                    producto = Convert.ToString(DGproductos.Rows[i].Cells[1].Value),
                    precio = Convert.ToDouble(DGproductos.Rows[i].Cells[2].Value),
                    cantidad = Convert.ToInt32(DGproductos.Rows[i].Cells[3].Value),
                    subtotal = Convert.ToDouble(DGproductos.Rows[i].Cells[4].Value)
                };
                ticket.listaProductos.Add(p);
            }

            //ticket.total = total;
            ticket.CrearPDF(pdfPath);
        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            if (radioButtonEnviar.Checked)
            {
                string pdfPath = Path.Combine(Path.GetTempPath(), "ticket.pdf");
                crear(pdfPath);

                Enviar_correo.FormSendMail formSendMail = new Enviar_correo.FormSendMail(pdfPath); // Pass the PDF path to the form
                formSendMail.ShowDialog();
            }
            else if (radioButtonImprimir.Checked)
            {
                crear(string.Empty); // Pass an empty string as pdfPath since it's not needed for printing
                crearTicket ticket = new crearTicket();
                ticket.imprimir();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción.");
            }
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

            ConexionSQL conn = new ConexionSQL();
            productos p = new productos();
            String codigoProducto = textBoxCodigo.Text;
            int length = codigoProducto.Length;
            labelLenght.Text = Convert.ToString(length);
            conn.AbrirConexion();
            
            if (length == 10)
            {
                try
                {
                    string selectQuery = "SELECT * FROM Productos WHERE codigoProducto = @codigoProducto";

                    // Crear y ejecutar el comando SQL
                    SqlCommand command = new SqlCommand(selectQuery, conn.AbrirConexion());
                    command.Parameters.AddWithValue("@codigoProducto", codigoProducto);

                    // Ejecutar la consulta y obtener los resultados
                    SqlDataReader result = command.ExecuteReader();
                    if (result.Read())
                    {
                        nombreProducto = result["descripcion"].ToString();
                        precioVenta = result["precioVenta"].ToString();

                        DGproductos.Rows.Add(codigoProducto, nombreProducto, precioVenta);
                        textBoxCodigo.Clear();
                        total += Convert.ToDouble(precioVenta);
                        labelTotal.Text = "Total: " + total.ToString();
                        p.total = total;
                        //  textBoxCodigo.Focus();
                    }
                    // Aquí puedes manejar los resultados obtenidos
                    // Por ejemplo, puedes leer los datos del lector (reader) y hacer algo con ellos


                    // Cerrar el lector y la conexión
                    result.Close();
                    conn.CerrarConexion();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
