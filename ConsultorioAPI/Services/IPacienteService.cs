using DB.Models;

namespace ConsultorioAPI.Services
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetPacientes();
        Task<Paciente> GetPaciente(int id);
        Task<Paciente> AddPaciente(Paciente model);
        Task<bool> UpdatePaciente(Paciente model);
        Task<bool> DeletePaciente(int id);
    }
}
