namespace VeterinariaAPI.Models
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public required string Name { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public int IdProveedor { get; set; }
        public required Proveedor Proveedor { get; set; }

        public required ICollection<CitaProducto>CitaProductos { get; set; }

        public Productos() { }
        public Productos(int idproducto, string name, decimal precio, int stock, int idproveedor, Proveedor Proveedor) {
            IdProducto = idproducto;
            Name = name;
            Precio = precio;
            Stock = stock;
            IdProveedor = idproveedor;
        
        }
    }
}
