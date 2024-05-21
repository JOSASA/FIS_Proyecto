using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using enviar_Correo;
using impresionTicket;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROYECTO.Enviar_correo
{
    public partial class FormSendMail : Form
    {
        private string pdfPath;

        public FormSendMail(string pdfPath)
        {
            InitializeComponent();
            this.pdfPath = pdfPath;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(email);
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string email = textBoxCorreo.Text;
            if (IsValidEmail(email))
            {
                logic objLogic = new logic();
                string body = @"<style>
                                h1{color:dodgerblue;}
                                h2{color:darkorange;}
                                </style>
                                <h1>Este es el body del correo</h1></br>
                                <h2>Este es el segundo párrafo</h2>";
                string result = await objLogic.SendMailAsync(email, "Ticket de compra", body, pdfPath);

                MessageBox.Show(result);

                this.Close();
            }
            else
            {
                MessageBox.Show("El correo electrónico no es válido.");
            }
        }
    }
}
