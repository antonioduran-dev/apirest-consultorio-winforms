namespace DB.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public int EspecialidadId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public virtual Especialidad? Especialidad { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Cita>? Citas { get; set; }
    }
}
