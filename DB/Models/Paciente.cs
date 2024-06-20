using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public char? Genero { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        [RegularExpression("^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$")]
        public string? Email { get; set; }
    }
}
