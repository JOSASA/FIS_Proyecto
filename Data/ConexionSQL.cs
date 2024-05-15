using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConexionSQL
    {
        SqlConnection conn;

        String nombreServidor = "DESKTOP-GRG3R00\\LUIS2_V_L";
        String nombreBD = "ABARROTECONCHA";
        String usuarioBD = "admin";
        String passwordBD = "admin";

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
                Console.WriteLine("ConexionSQL: " + ex.Message);
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
        public DataTable ObtenerCompra()
        {
            DataTable dtCompras = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Compras", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtCompras);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtCompras;
        }
        public DataTable ObtenerUsuarios()
        {
            DataTable dtCompras = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtCompras);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtCompras;
        }
        public DataTable ObtenerProveedor()
        {
            DataTable dtCompras = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedores", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtCompras);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtCompras;
        }
        public DataTable ObtenerProductos()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtClientes);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtClientes;
        }
        public DataTable ObtenerClientes()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtClientes);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtClientes;
        }
        public bool AgregarCliente(int idCliente, string nombre, string apellido, string telefono, string correo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (IdCliente, Nombre, Apellido, Telefono, Correo) VALUES (@IdCliente, @Nombre, @Apellido, @Telefono, @Correo)", conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
