using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impresionTicket
{
    public class crearTicket
    {
        public string empresa { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public Image logotipo { get; set; }
        productos p = new productos();
        public List<productos> listaProductos = new List<productos>();
        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();
        public void imprimir(crearTicket p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimeTicket);
            vista.Document = doc;
            vista.Show();
          //  doc.Print();
        }
        public void imprimeTicket(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            Font fuente = new Font("consola", 15, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;
                e.Graphics.DrawImage(logotipo, 15,20,200,200);
                posY += 160;
                e.Graphics.DrawString(empresa, fuente,Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString(direccion, fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString(telefono, fuente, Brushes.Black, posX, posY);
                posY += 40;
                //posX = 100;
                fuente = new Font("consola", 13);
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 10;
                e.Graphics.DrawString("Codigo", fuente, Brushes.Black, posX, posY);
                posX = 115;
                e.Graphics.DrawString("Precio", fuente, Brushes.Black, posX, posY);
                posX = 200;
                e.Graphics.DrawString("Cantidad", fuente, Brushes.Black, posX, posY);
                posX = 300;
                e.Graphics.DrawString("Subtotal", fuente, Brushes.Black, posX, posY);
                posX = 10;

                posY += 10;
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 20;
                fuente = new Font("consola", 8);
                for (int i = 0; i < listaProductos.Count-1; i++)
                {
                    e.Graphics.DrawString(listaProductos[i].producto, fuente, Brushes.Black, posX, posY);
                    posY += 20;
                    e.Graphics.DrawString(listaProductos[i].codigo + espaciar(listaProductos[i].cantidad.ToString().Length, 28) + listaProductos[i].precio + espaciar(listaProductos[i].cantidad.ToString().Length, 23) + listaProductos[i].cantidad + espaciar(listaProductos[i].cantidad.ToString().Length, 34) + listaProductos[i].subtotal + " ", fuente, Brushes.Black, posX, posY);
                    posY += 25;
                }

                e.Graphics.DrawString("Total: " + p.total, fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString("Gracias por su compra", fuente, Brushes.Black, posX, posY);
                posY += 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*public string espacios(int valor)
        {

        }*/
        public string espaciar(int tamaño, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamaño;

            for (int i = 0; i < subvalor; i++)
            {
                espacio = espacio + " ";
            }

            return espacio;
        }

    }
}
