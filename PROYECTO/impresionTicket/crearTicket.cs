using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml.Linq;
using Image = System.Drawing.Image;
using Font = System.Drawing.Font;

namespace impresionTicket
{
    public class crearTicket
    {
        public string empresa
        {
            get; set;
        }
        public string direccion
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }
        public Image logotipo
        {
            get; set;
        }
        public List<productos> listaProductos = new List<productos>();
        public decimal total
        {
            get; set;
        }

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        public void imprimir()
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimeTicket);
            vista.Document = doc;
            vista.Show();
            // doc.Print();
        }

        public void imprimeTicket(object sender, PrintPageEventArgs e)
        {
            try
            {
                DibujarTicket(e.Graphics, 10, 10, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CrearPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();
            PdfContentByte cb = writer.DirectContent;

            // Start drawing content
            using (var ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(500, 1000); // adjust size as needed
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    DibujarTicket(g, 10, 10, cb);
                }
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(doc.PageSize.Width - 20, doc.PageSize.Height - 20);
                img.SetAbsolutePosition(10, doc.PageSize.Height - img.ScaledHeight - 10);
                doc.Add(img);
            }

            doc.Close();
        }

        private void DibujarTicket(Graphics g, float posX, float posY, PdfContentByte cb)
        {
            Font fuente = new Font("consola", 15, FontStyle.Bold);

            if (logotipo != null)
            {
                if (cb != null)
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logotipo, System.Drawing.Imaging.ImageFormat.Png);
                    logo.ScaleAbsolute(100, 100);
                    logo.SetAbsolutePosition(15, posY);
                    cb.AddImage(logo);
                }
                else
                {
                    g.DrawImage(logotipo, 15, posY, 100, 100);
                }
                posY += 160;
            }

            DrawText(g, cb, empresa, fuente, Brushes.Black, posX, posY);
            posY += 30;
            DrawText(g, cb, direccion, fuente, Brushes.Black, posX, posY);
            posY += 30;
            DrawText(g, cb, telefono, fuente, Brushes.Black, posX, posY);
            posY += 40;
            fuente = new Font("consola", 13);
            DrawText(g, cb, "-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
            posY += 10;
            DrawText(g, cb, "Codigo", fuente, Brushes.Black, posX, posY);
            posX = 115;
            DrawText(g, cb, "Precio", fuente, Brushes.Black, posX, posY);
            posX = 200;
            DrawText(g, cb, "Cantidad", fuente, Brushes.Black, posX, posY);
            posX = 300;
            DrawText(g, cb, "Subtotal", fuente, Brushes.Black, posX, posY);
            posX = 10;

            posY += 10;
            DrawText(g, cb, "-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
            posY += 20;
            fuente = new Font("consola", 8);
            for (int i = 0; i < listaProductos.Count; i++)
            {
                DrawText(g, cb, listaProductos[i].producto, fuente, Brushes.Black, posX, posY);
                posY += 20;
                DrawText(g, cb, listaProductos[i].codigo + espaciar(listaProductos[i].cantidad.ToString().Length, 28) + listaProductos[i].precioVenta + espaciar(listaProductos[i].cantidad.ToString().Length, 23) + listaProductos[i].cantidad + espaciar(listaProductos[i].cantidad.ToString().Length, 34) + listaProductos[i].subtotal + " ", fuente, Brushes.Black, posX, posY);
                posY += 25;
            }

            DrawText(g, cb, "Total: " + total, fuente, Brushes.Black, posX, posY);
            posY += 30;
            DrawText(g, cb, "-------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
            posY += 30;
            DrawText(g, cb, "Gracias por su compra", fuente, Brushes.Black, posX, posY);
            posY += 30;
        }


        private void DrawText(Graphics g, PdfContentByte cb, string text, Font font, Brush brush, float x, float y)
        {
            if (g != null)
            {
                g.DrawString(text, font, brush, x, y);
            }

            if (cb != null)
            {
                cb.BeginText();
                cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false), font.Size);
                cb.SetTextMatrix(x, y);
               // cb.ShowText(text);
                cb.EndText();
            }
        }

        public string espaciar(int tamaño, int valor)
        {
            string espacio = "";
            int subvalor = valor - tamaño;

            for (int i = 0; i < subvalor; i++)
            {
                espacio += " ";
            }

            return espacio;
        }
    }

}

