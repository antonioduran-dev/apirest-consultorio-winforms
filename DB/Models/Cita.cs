namespace DB.Models
{
    public class Cita
    {
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateOnly FechaCita { get; set; }
        public TimeOnly HoraCita {  get; set; }
        public string? MotivoCita { get; set; }
        public virtual Paciente? Paciente { get; set; }
        public virtual Medico? Medico { get; set; }
    }
}
