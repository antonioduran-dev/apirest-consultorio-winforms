
namespace ConsultorioApp.Models
{
    public class MedicoModel
    {
        public int MedicoId { get; set; }
        public string Especialidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string Usuario { get; set;}
    }
}
