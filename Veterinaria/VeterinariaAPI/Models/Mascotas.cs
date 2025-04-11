namespace VeterinariaAPI.Models
{
    public class Mascotas
    {
       
        public required int IdMascota { get; set; }
        public required string Nombre { get; set; } 
        public required string Especie { get; set; }
        public required string Raza { get; set; }
        public required int Edad { get; set; }

        public required int IdCliente { get; set; } 
        public required Clientes Cliente { get; set; } 

        public required ICollection<Citas> Citas { get; set; }

        public Mascotas() { }
        public Mascotas(int id, string nombre, string especie, string raza, int edad, int idCliente, Clientes cliente, ICollection<Citas>? citas = null)
        {
            IdMascota = id;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            IdCliente = idCliente;
            Cliente = cliente;
            Citas = citas ?? new List<Citas>(); 
        }
    }
}

