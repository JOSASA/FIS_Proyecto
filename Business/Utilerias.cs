using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Utilerias
    {
        public static String G_NombreUsuario;
        public static String G_Usuario;
        public static DateTime G_LoginTime;
        public static Boolean fnValidaVacios(String valor)
        {

            return valor.Length > 0;
        }
    }
}
