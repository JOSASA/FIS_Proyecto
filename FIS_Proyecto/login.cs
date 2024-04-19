

namespace FIS_Proyecto
{
    using BussinesRules;
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Poder validar datos vs BD vs fileEncrypt
                Usuarios mUsuarios = new Usuarios();
                mUsuarios.pwd = txtPassword.Text;
                mUsuarios.usuario = txtUsuario.Text;

                if (mUsuarios.fnValidaLogin())
                {
                    //ingresa en el sistema

                    //los permisos del usuario que hizo login 
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No es valido el usuario o contraseña", "Aviso POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[btnIngresar_Click] " + ex.Message);
            }
        }

    }
}
