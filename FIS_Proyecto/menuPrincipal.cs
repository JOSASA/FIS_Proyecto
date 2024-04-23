using BussinesRules;

namespace FIS_Proyecto
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Sistema POS";
                login login = new login();
                login.ShowDialog();

                this.Text = this.Text + "--> UserName: " + Utilerias.G_Usuario + " Nombre: [" + Utilerias.G_NombreUsuario + "]";
                Usuarios mUsuarios = new Usuarios();

            }
            catch (Exception ex)
            {
                Console.WriteLine("[fmr_principal_Load] " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Mostrar al usuario
            Utilerias.G_NombreUsuario = textBox1.Text;
        }
    }
}
