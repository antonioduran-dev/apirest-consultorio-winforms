using ConsultorioAPI.Utils;
using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ConsultorioDBContext _dbContext;
        private readonly Utilities _utilities;
        public UsuarioService(ConsultorioDBContext dbContext, Utilities utilities)
        {
            _dbContext = dbContext;
            _utilities = utilities;

        }

        // get all registers from DB
        public async Task<IEnumerable<Usuario>> Get()
        {
            try
            {
                return await _dbContext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get a register from DB by id
        public async Task<Usuario> Get(int id)
        {
            try
            {
                return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetByUsername(string username)
        {
            try
            {
                return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.NombreUsuario == username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add a new a register to DB
        public async Task<Usuario> Add(Usuario model)
        {
            try
            {
                model.Clave = _utilities.EncriptarSHA256(model.Clave);
                _dbContext.Usuarios.Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update a register from DB
        public async Task<bool> Update(Usuario model)
        {
            try
            {
                var modelDB = await _dbContext.Usuarios.FindAsync(model.UsuarioId);

                if(modelDB != null)
                {
                    // create and encrypt new password.
                    modelDB.NombreUsuario = model.NombreUsuario;
                    modelDB.Clave = _utilities.EncriptarSHA256(model.Clave);

                    _dbContext.Usuarios.Update(modelDB);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete a register from DB
        public async Task<bool> Delete(int id)
        {
            try
            {
                var model = await _dbContext.Usuarios.FindAsync(id);

                if (model == null)
                    return false;

                _dbContext.Usuarios.Remove(model);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
