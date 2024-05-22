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
using impresionTicket;

namespace PROYECTO.Forms
{
    public partial class formLoginHistory : Form
    {
        ConexionSQL conn = new ConexionSQL();
        public formLoginHistory()
        {
            InitializeComponent();
        }

        private void formLoginHistory_Load(object sender, EventArgs e)
        {
            DGlogHistory.DataSource = conn.ObtenerLoginHistory();
        }
    }
}
