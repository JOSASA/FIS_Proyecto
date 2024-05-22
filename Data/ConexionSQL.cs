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

        String nombreServidor = "LAPTOP-E87U5309\\SAMUEL2_S_G";
        String nombreBD = "ABARROTECONCHA";
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
        public DataTable buscarCoincidencias(string textoBusqueda, string nombreTabla, string referencia)
        {
            DataTable tablaResultados = new DataTable();
            try
            {
                string consulta = $"SELECT * FROM {nombreTabla} WHERE {referencia} LIKE '%{textoBusqueda}%'";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tablaResultados);
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
            return tablaResultados;
        }
        public DataTable ObtenerDatosTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = $"SELECT * FROM {nombreTabla}";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
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
            return tabla;
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
        public DataTable ObtenerLoginHistory()
        {
            DataTable dtCompras = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LoginHistory", conn))
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
        public DataTable ObtenerVentas()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas", conn))
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
        public DataTable ObtenerCompras()
        {
            DataTable dtClientes = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT codigoProducto, descripcion, precioCosto, hay, precioCosto * hay AS valor_total FROM productos;", conn))
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
        public double ObtenerTotalCompras()
        {
            double total = 0.0; // Initialize total to 0.0 for double precision
            ConexionSQL conn = new ConexionSQL();
            using (conn.AbrirConexion()) // Use using for connection management
            {
                try
                {
                    conn.AbrirConexion();

                    string selectQuery = "SELECT SUM(precio_costo * hay) AS valor_total_inventario FROM productos;";
                    SqlCommand command = new SqlCommand(selectQuery, conn.AbrirConexion());

                    using (SqlDataReader reader = command.ExecuteReader()) // Use using for reader management
                    {
                        if (reader.Read())
                        {
                            total = reader.GetDouble(reader.GetOrdinal("valor_total_inventario")); // Get double directly
                        }
                        else
                        {
                            // Handle the case where no records are found (optional)
                            // Console.WriteLine("No records found in productos table.");
                        }
                    }
                }
                catch (SqlException ex) // Catch specific SQL exceptions
                {
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
                catch (Exception ex) // Catch general exceptions for unexpected errors
                {
                    Console.WriteLine("General Exception: " + ex.Message);
                }
            }

            return total;
        }

        public void ActualizarStock(string codigoProducto, int cantidadVendida)
        {
            string updateQuery = "UPDATE Productos SET hay = hay - @cantidadVendida WHERE codigoProducto = @codigoProducto";

            using (SqlCommand command = new SqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                command.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);

                command.ExecuteNonQuery();
            }
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
