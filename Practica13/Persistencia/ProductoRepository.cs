using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica13.Persistencia
{
    public class ProductoRepository
    {
        private string connectionString = "Server=localhost;Port=3306;Database=p13;uid=root;Password=root;";

        public DataTable ObtenerProductos()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, nombre, descripcion, marca, precio, inventario FROM productos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void InsertarProducto(string nombre, string descripcion, string marca, decimal precio, int inventario)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO productos (nombre, descripcion, marca, precio, inventario) VALUES (@nombre, @descripcion, @marca, @precio, @inventario)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@inventario", inventario);
                command.ExecuteNonQuery();
            }
        }

        public void EditarProducto(int id, string nombre, string descripcion, string marca, decimal precio, int inventario)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE productos SET nombre=@nombre, descripcion=@descripcion, marca=@marca, precio=@precio, inventario=@inventario WHERE id=@id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@inventario", inventario);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM productos WHERE id=@id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
