namespace VeterinariaAPI.Models
{
    public class CitaProducto
    {   
        public int Cantidad { get; set; }
        public int IdCita { get; set; }
        public required Citas Citas { get; set; }

        public int IdProducto { get; set; }
        public required Productos Productos { get; set; }
        
        public CitaProducto(int cantidad) {
        Cantidad=cantidad;

        }


    } 
}
