using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Services
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly ConsultorioDBContext _dbContext;
        public EspecialidadService(ConsultorioDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // get all registers from DB
        public async Task<IEnumerable<Especialidad>> GetEspecialidades()
        {
            try
            {
                return await _dbContext.Especialidades.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // get a register from DB by id
        public async Task<Especialidad> GetEspecialidad(int id)
        {
            try
            {
                return await _dbContext.Especialidades.FirstOrDefaultAsync(e => e.EspecialidadId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add a new a register to DB
        public async Task<Especialidad> AddEspecialidad(Especialidad model)
        {
            try
            {
                _dbContext.Especialidades.Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update a register from DB
        public async Task<bool> UpdateEspecialidad(Especialidad model)
        {
            try
            {
                var modelDB = await _dbContext.Especialidades.FindAsync(model.EspecialidadId);

                if(modelDB!= null)
                {
                    modelDB.Nombre = model.Nombre;
                    _dbContext.Especialidades.Update(modelDB);
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
        public async Task<bool> DeleteEspecialidad(int id)
        {
            try
            {
                var model = await _dbContext.Especialidades.FindAsync(id);

                if (model == null)
                    return false;

                _dbContext.Especialidades.Remove(model);
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
