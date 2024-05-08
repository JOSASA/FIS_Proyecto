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
    public partial class frmUsuarios : Form
    {
        ConexionSQL ConexionSQL = new ConexionSQL();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DGusuarios.DataSource = ConexionSQL.ObtenerUsuarios();
        }
    }
}
