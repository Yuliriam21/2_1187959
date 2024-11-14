using System.Data;
using Practica13.Persistencia;

namespace Practica13.Negocio
{
    public class ProductoService
    {
        private ProductoRepository productoRepository = new ProductoRepository();

        public DataTable ObtenerProductos()
        {
            return productoRepository.ObtenerProductos();
        }

        public void GuardarProducto(string nombre, string descripcion, string marca, decimal precio, int inventario)
        {
            productoRepository.InsertarProducto(nombre, descripcion, marca, precio, inventario);
        }

        public void EditarProducto(int id, string nombre, string descripcion, string marca, decimal precio, int inventario)
        {
            productoRepository.EditarProducto(id, nombre, descripcion, marca, precio, inventario);
        }

        public void EliminarProducto(int id)
        {
            productoRepository.EliminarProducto(id);
        }
    }
}
