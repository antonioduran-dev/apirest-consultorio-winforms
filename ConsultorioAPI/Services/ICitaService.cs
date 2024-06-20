using DB.Models;

namespace ConsultorioAPI.Services
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> GetCitas();
        Task<Cita> GetCita(int id);
        Task<Cita> AddCita(Cita model);
        Task<bool> UpdateCita(Cita model);
        Task<bool> DeleteCita(int id);
    }
}
