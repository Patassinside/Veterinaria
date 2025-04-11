namespace VeterinariaAPI.Models
{
    public class Clientes
    {
        public required int IdCliente { get; set; }
        public required string Nombre { get; set; }
        public int Telefono { get; set; }
        public required string Email { get; set; }
        public required ICollection<Mascotas> Mascotas { get; set; } = new List<Mascotas>();

        public Clientes() { }
        public Clientes(int id, string nombre, int telefono, string email)
        {
            IdCliente = id;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
    
        }
    }
}

