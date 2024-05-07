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
namespace PROYECTO.Forms
{
    public partial class frmVentas : Form
    {
        private ConexionSQL conexion;

        public frmVentas()
        {
            InitializeComponent();
            conexion = new ConexionSQL();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            crearTicket ticket = new crearTicket();
            productos p = new productos();  
            ticket.empresa = labelEmpresa.Text;
            ticket.direccion = labelDireccion.Text; 
            ticket.telefono = labelTelefono.Text;   
            ticket.logotipo = pictureBox1.Image;

            for (int i = 0; i < DGproductos.Rows.Count; i++)
            {
                p = new productos();
                p.codigo = Convert.ToInt32(DGproductos.Rows[i].Cells[0].Value);
                p.producto = Convert.ToString(DGproductos.Rows[i].Cells[1].Value);
                p.precio = Convert.ToDouble(DGproductos.Rows[i].Cells[2].Value);
                p.cantidad = Convert.ToInt32(DGproductos.Rows[i].Cells[3].Value);
                p.subtotal = Convert.ToDouble(DGproductos.Rows[i].Cells[4].Value);
                ticket.listaProductos.Add(p);   
            }
            ticket.imprimir(ticket);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
