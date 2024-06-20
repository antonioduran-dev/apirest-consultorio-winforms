using DB.Models;

namespace ConsultorioAPI.Services
{
    public interface IMedicoService
    {
        Task<IEnumerable<Medico>> GetMedicos();
        Task<IEnumerable<Cita>> GetCitasByMedicoId(int medicoId);
        Task<Medico> GetMedicoByUsuarioId(int usuarioId);
        Task<Medico> GetMedico(int id);
        Task<Medico> AddMedico(Medico model);
        Task<bool> UpdateMedico(Medico model);
        Task<bool> DeleteMedico(int id);
    }
}
