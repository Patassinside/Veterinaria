namespace VeterinariaAPI.Models
{
    public class Servicios
    {
        public required int IdServicio { get; set; }
        public required string Nombre { get; set; }
        public required decimal Precio { get; set; }
        public required ICollection<Citas> Citas { get; set; }

        public Servicios() { }
        public Servicios(int id, string nombre, decimal precio, ICollection<Citas>? citas = null)
        {
            IdServicio = id;
            Nombre = nombre;
            Precio = precio;
            Citas = citas ?? new List<Citas>(); 
        }
    }
}

