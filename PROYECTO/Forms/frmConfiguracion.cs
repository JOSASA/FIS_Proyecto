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

namespace PROYECTO.Forms
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void CerrarSesion()
        {
            Business.Usuarios mUsuarios = new Business.Usuarios();
            ConexionSQL conn = new ConexionSQL();
            conn.AbrirConexion();
            
            string updateQuery = "UPDATE LoginHistory SET LogoutTime = @LogoutTime WHERE LoginTime = @LoginTime";

            using (SqlCommand command = new SqlCommand(updateQuery, conn.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@LogoutTime", DateTime.Now);
                command.Parameters.AddWithValue("@LoginTime", Utilerias.G_LoginTime);
                command.ExecuteNonQuery();
            }
            conn.CerrarConexion();
            Application.Restart();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CerrarSesion(); 
        }
    }
}
