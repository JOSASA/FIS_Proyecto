using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            try
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                labelNombre.Text = ("   " + Business.Utilerias.G_Usuario);
                lblDate.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[fmr_principal_Load] " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
