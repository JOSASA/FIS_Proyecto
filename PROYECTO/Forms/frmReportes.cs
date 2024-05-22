using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using impresionTicket;

namespace PROYECTO.Forms
{
    
    public partial class frmReportes : Form
    {
        ConexionSQL conexionSQL = new ConexionSQL();
        public frmReportes()
        {
            InitializeComponent();
        }

       

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DGventas.DataSource = conexionSQL.ObtenerVentas();
            DGcompras.DataSource = conexionSQL.ObtenerCompras();
            labelTotalCompras.Text = Convert.ToString(conexionSQL.ObtenerTotalCompras());
        }

        private void DBcompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
