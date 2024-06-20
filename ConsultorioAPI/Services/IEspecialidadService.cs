using DB.Models;

namespace ConsultorioAPI.Services
{
    public interface IEspecialidadService
    {
        Task<IEnumerable<Especialidad>> GetEspecialidades();
        Task<Especialidad> GetEspecialidad(int id);
        Task<Especialidad> AddEspecialidad(Especialidad model);
        Task<bool> UpdateEspecialidad(Especialidad model);
        Task<bool> DeleteEspecialidad(int id);
    }
}
