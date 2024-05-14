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

        String nombreServidor = "DESKTOP-TMJM67R\\SQLEXPRESS";
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
        public DataTable ObtenerProductosBajoStock()
        {
            DataTable dtProductosBajoStock = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE hay <= 10", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtProductosBajoStock);
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
            return dtProductosBajoStock;
        }

        public void InsertarCompra(string codigoProducto, string descripcion, string unidadMedida, string ubicacion, decimal precioCosto, decimal precioVenta, int hay, int minimo, int maximo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Compras (codigoProducto, descripcion, unidadMedida, ubicacion, precioCosto, precioVenta, hay, minimo, maximo) VALUES (@codigoProducto, @descripcion, @unidadMedida, @ubicacion, @precioCosto, @precioVenta, @hay, @minimo, @maximo)", conn))
                {
                    cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@unidadMedida", unidadMedida);
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
                    cmd.Parameters.AddWithValue("@precioCosto", precioCosto);
                    cmd.Parameters.AddWithValue("@precioVenta", precioVenta);
                    cmd.Parameters.AddWithValue("@hay", hay);
                    cmd.Parameters.AddWithValue("@minimo", minimo);
                    cmd.Parameters.AddWithValue("@maximo", maximo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
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
        }

        public DataTable ObtenerCompras()
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

        public void ConfirmarCompra()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Productos SET hay = hay + c.hay FROM Compras c WHERE Productos.codigoProducto = c.codigoProducto; DELETE FROM Compras;", conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
        }
    }
}
