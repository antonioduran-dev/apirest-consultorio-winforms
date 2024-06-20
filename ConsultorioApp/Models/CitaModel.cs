using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioApp.Models
{
    public class CitaModel
    {
        public int CitaId { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreMedico { get; set; }
        public DateOnly FechaCita { get; set; }
        public TimeOnly HoraCita { get; set; }
        public string? MotivoCita { get; set; }
    }
}
