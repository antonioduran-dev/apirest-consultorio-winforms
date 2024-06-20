using DB.Models;

namespace ConsultorioAPI.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> Get();
        Task<Usuario> Get(int id);
        Task<Usuario> GetByUsername(string username);
        Task<Usuario> Add(Usuario model);
        Task<bool> Update(Usuario model);
        Task<bool> Delete(int id);
    }
}
