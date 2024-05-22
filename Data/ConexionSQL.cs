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

    //<<<<<<< Updated upstream
            //String nombreServidor = "LEGION\\ALAN_O";
    //=======
            String nombreServidor = "DESKTOP-TMJM67R\\SQLEXPRESS";
    //>>>>>>> Stashed changes
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
            public bool AgregarCliente(string nombre, string apellido, string telefono, string correo)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo) VALUES (@Nombre, @Apellido, @Telefono, @Correo)", conn))
                    {
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
            public bool EliminarCliente(int idCliente)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE IdCliente = @IdCliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
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

            public bool ActualizarCliente(int idCliente, string nombre, string apellido, string telefono, string correo)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo = @Correo WHERE IdCliente = @IdCliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Correo", correo);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
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
            public DataTable ObtenerProductosConStockBajo()
            {
                DataTable dtProductos = new DataTable();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE hay < 10", conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtProductos);
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
                return dtProductos;
            }

            public bool ActualizarStockProducto(string codigoProducto, int nuevoStock)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Productos SET hay = @NuevoStock WHERE codigoProducto = @CodigoProducto", conn))
                    {
                        cmd.Parameters.AddWithValue("@NuevoStock", nuevoStock);
                        cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
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
        public DataTable ObtenerProveedor()
        {
            DataTable dtProveedores = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedores", conn))
                {
                    AbrirConexion();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtProveedores);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return dtProveedores;
        }

        public bool AgregarProveedor(long numero, string nombre, string representante, long telefono, string correo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Proveedores (numero, nombre, representante, telefono, correo) VALUES (@numero, @nombre, @representante, @telefono, @correo)", conn))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@representante", representante);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    AbrirConexion();
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
                CerrarConexion();
            }
        }

        public DataTable ObtenerProductos()
        {
            DataTable dtProductos = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conn))
                {
                    AbrirConexion();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtProductos);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return dtProductos;
        }

        public bool AgregarProducto(string codigoProducto, string descripcion, string unidadMedida, string ubicacion, decimal precioCosto, decimal precioVenta, int hay, int minimo, int maximo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Productos(codigoProducto, descripcion, unidadMedida, ubicacion, precioCosto, precioVenta, hay, minimo, maximo) VALUES(@codigoProducto, @descripcion, @unidadMedida, @ubicacion, @precioCosto, @precioVenta, @hay, @minimo, @maximo)", conn))
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

                    AbrirConexion();
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
                CerrarConexion();
            }
        }
        public bool EliminarProveedor(long numero)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Proveedores WHERE numero = @numero", conn))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);

                    AbrirConexion();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool ActualizarProveedor(long numero, string nombre, string representante, long telefono, string correo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Proveedores SET nombre = @nombre, representante = @representante, telefono = @telefono, correo = @correo WHERE numero = @numero", conn))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@representante", representante);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    AbrirConexion();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
