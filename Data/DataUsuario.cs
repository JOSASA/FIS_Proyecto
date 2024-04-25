using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataUsuario
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;
        public String NombreDeUsuario = "";
        public String UserName = "";

        public void Insertar(String nombre, String apellidoP, String apellidoM, String correo, String usuario, String password, String telefono, int perfil)
        {
            try
            {


                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_InsertarUsuario";

                //Tipo de comando
                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametro
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@apellidop", apellidoP);
                comandoSQL.Parameters.AddWithValue("@apellidom", apellidoM);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@password", password);
                comandoSQL.Parameters.AddWithValue("@telefono", telefono);
                comandoSQL.Parameters.AddWithValue("@idPerfil", perfil);

                //Ejecutar query
                comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();

                //Cerrar conexion
                renglonesAfectados = 1;
                Console.WriteLine("Se agrego correctamente");

            }
            catch (Exception ex)
            {

                Console.WriteLine("DataUsuario: Insertar" + ex.Message);
                renglonesAfectados = 0;
            }



        }
        public void Auntenticar(String usuario, String password)
        {
            try
            {


                //Abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();

                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_ValidaUsuario";

                //Tipo de comando
                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametro
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@pwd", password);

                //Ejecutar query
                //renglonesAfectados = comandoSQL.ExecuteNonQuery();
                SqlDataReader result = comandoSQL.ExecuteReader();
                if (result.Read())
                {
                    renglonesAfectados = 1;
                    UserName = result["usuario"].ToString();
                    NombreDeUsuario = result["nombre"].ToString();
                }
                else
                {
                    renglonesAfectados = 0;
                }


                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion

            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuario: Auntenticar" + ex.Message);
                renglonesAfectados = 0;
            }

        }
    }
}
