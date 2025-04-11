namespace VeterinariaAPI.Models
{
    public class Citas
    {
        public int IdCita { get; set; }
        public required string FechaHora { get; set; } 
        public required int IdServicio { get; set; }
        public required Servicios Servicio { get; set; }
        public required int IdMascota { get; set; }
        public required Mascotas Mascota { get; set; }

        public required ICollection<CitaProducto> CitaProducto { get; set; }

        public Citas() { }

        public Citas(int idCita, string fechaHora, int idServicio, int idMascota)
        {
            IdCita = idCita;
            FechaHora = fechaHora;
            IdServicio = idServicio;
            IdMascota = idMascota;
        }
    }
}
