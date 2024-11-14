using Practica13.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Practica13
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=p13;uid=root;Password=root;";

        public Form2()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, nombre, descripcion, marca, precio, inventario FROM productos";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void GuardarProducto()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO productos (nombre, descripcion, marca, precio, inventario) VALUES (@nombre, @descripcion, @marca, @precio, @inventario)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    command.Parameters.AddWithValue("@marca", txtMarca.Text);
                    command.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    command.Parameters.AddWithValue("@inventario", Convert.ToInt32(txtStock.Text));
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Producto guardado exitosamente.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
            }
            CargarDatos(); 
            LimpiarCampos();
        }

        private void EditarProducto(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE productos SET nombre=@nombre, descripcion=@descripcion, marca=@marca, precio=@precio, inventario=@inventario WHERE id=@id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    command.Parameters.AddWithValue("@marca", txtMarca.Text);
                    command.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    command.Parameters.AddWithValue("@inventario", Convert.ToInt32(txtStock.Text));
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Producto editado exitosamente.");
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el producto: " + ex.Message);
                }
            }
            CargarDatos(); // Recargar los datos en el DataGridView
            LimpiarCampos();
        }

        private void EliminarProducto(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM productos WHERE id=@id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Producto eliminado exitosamente.");
                    CargarDatos(); // Recargar los datos en el DataGridView
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que la fila sea válida
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                txtMarca.Text = row.Cells["marca"].Value.ToString();
                txtPrecio.Text = row.Cells["precio"].Value.ToString();
                txtStock.Text = row.Cells["inventario"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                EliminarProducto(id);
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                EditarProducto(id);
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }
    }
}
