using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace PROYECTO.Forms
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void chk_estatus_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chk_estatus.Checked)
        //    {
        //        chk_estatus.Text = "Activo";
        //    }
        //    else
        //    {
        //        chk_estatus.Text = "Inactivo";
        //    }
        //}
        //private void frm_catUsuarios_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        chk_estatus.Checked = false;
        //        chk_estatus.Text = "Inactivo";
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
        //    openFileDialog.Title = "Select an Image File";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        pbFoto.Image = new Bitmap(openFileDialog.FileName);
        //        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios mUsuario = new Usuarios();


            string nombre = txtNombre.Text;
            string apellidoP = txtApellidoP.Text;
            string apellidoM = txtApellidoM.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            int perfil = 1;

            if (Utilerias.fnValidaVacios(nombre) == false)
                MessageBox.Show("Es obligatorio ingresar el nombre de usuario");
            else if (!Utilerias.fnValidaVacios(apellidoP))
                MessageBox.Show("Es obligatorio ingresar el apellido Paterno de usuario");
            else
            {
                mUsuario.nombre = nombre;
                mUsuario.usuario = usuario;
                mUsuario.apellidoP = apellidoP;
                mUsuario.apellidoM = apellidoM;
                mUsuario.correo = correo;
                mUsuario.telefono = telefono;
                mUsuario.pwd = password;
                mUsuario.perfil = perfil;

                //todos los demas campos
                if (mUsuario.fnGuardar())
                    MessageBox.Show("Usuario grabado con exito!!");
                // limpiar todos los campos
                else
                    MessageBox.Show("No es posible guardar datos \n consulte a su administrador de sistemas");
            }
        }
    }
}
