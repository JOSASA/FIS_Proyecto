
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    internal class ConexionSQL
    {
        SqlConnection conn;
        String nombreServidor = "LAPTOP-E87U5309\\SAMUEL2_S_G";
        String nombreBD = "POS";
        String usuarioBD = "sa";
        String passwordBD = "12345";
        private String ConnectionString;

        public ConexionSQL()
        {
            try
            {
                ConnectionString = $"Server={nombreServidor}; Database={nombreBD}; User Id={usuarioBD}; Password={passwordBD};";
                conn = new SqlConnection(ConnectionString);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ConexionSQL: "+ex.Message);
            }
            //Agregar connectionString
            
          


        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
