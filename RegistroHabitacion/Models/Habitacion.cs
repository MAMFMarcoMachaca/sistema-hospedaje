namespace RegistroHabitacion.Models;

public class Habitacion
{
    public int Numero { get; set; }
    public string Tipo { get; set; } = "";
    public decimal PrecioNoche {get; set; }
    public string Estado { get; set; } = "";
}
