using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuarios
    {
        public int clave
        {
            get; set;
        }
        public String usuario
        {
            get; set;
        }
        public String pwd
        {
            get; set;
        }
        public String nombre
        {
            get; set;
        }
        public String apellidoP
        {
            get; set;
        }
        public String apellidoM
        {
            get; set;
        }
        public String correo
        {
            get; set;
        }
        public String telefono
        {
            get; set;
        }

        public int perfil
        {
            get; set;
        }



        //metodos
        public Boolean fnValidaLogin()
        {
            try
            {
                Boolean resultado = false;



                //Recoger datos del login
                Data.DataUsuario mUsuario = new Data.DataUsuario();
                mUsuario.Auntenticar(usuario, pwd);
                if (mUsuario.renglonesAfectados == 1)
                {

                    resultado = true;
                    Utilerias.G_NombreUsuario = mUsuario.NombreDeUsuario;
                    Utilerias.G_Usuario = mUsuario.UserName;
                }
                else
                {

                    resultado = false;
                    Utilerias.G_NombreUsuario = "";
                    Utilerias.G_Usuario = "";

                }
                return resultado;

                //conectar BD



                //Validar Consulta

            }
            catch (Exception e)
            {
                Console.WriteLine("[fnValidaLogin]" + e.ToString());
                return false;
            }
        }

        //fnGuradar
        public Boolean fnGuardar()
        {
            try
            {
                Boolean resultado = false;
                Data.DataUsuario vUsuario = new Data.DataUsuario();
                vUsuario.Insertar(nombre, apellidoP, apellidoM, correo, usuario, pwd, telefono, clave);
                if (vUsuario.renglonesAfectados > 0)
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
