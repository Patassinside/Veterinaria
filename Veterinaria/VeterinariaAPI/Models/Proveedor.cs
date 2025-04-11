namespace VeterinariaAPI.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public required string Name { get; set; }
        public int Telefono { get; set; }
        public required string Email { get; set; }

        public required ICollection<Productos> Productos { get; set; }
        public Proveedor() { }
        public Proveedor(int id, string name, int telefono, string email, ICollection<Productos> Productos) { 
            IdProveedor = id;
            Name = name; 
            Telefono = telefono;
            Email = email;
        }



    }
}
