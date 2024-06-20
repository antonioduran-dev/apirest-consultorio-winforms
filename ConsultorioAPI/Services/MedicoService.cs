using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly ConsultorioDBContext _dbContext;
        public MedicoService(ConsultorioDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // get all registers from DB
        public async Task<IEnumerable<Medico>> GetMedicos()
        {
            try
            {
                return await _dbContext.Medicos
                    .Include(m => m.Especialidad) // includes the related foreign key data.
                    .Include(m => m.Usuario) // includes the related foreign key data.
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get a register from DB by id
        public async Task<Medico> GetMedico(int id)
        {
            try
            {
                return await _dbContext.Medicos
                    .Include(m => m.Especialidad)
                    .Include(m => m.Usuario)
                    .FirstOrDefaultAsync(m => m.MedicoId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Medico> GetMedicoByUsuarioId(int usuarioId)
        {
            try
            {
                return await _dbContext.Medicos
                    .Include(m => m.Especialidad)
                    .FirstOrDefaultAsync(m => m.UsuarioId == usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get citas from a specific medico id.
        public async Task<IEnumerable<Cita>> GetCitasByMedicoId(int medicoId)
        {
            try
            {
                return await _dbContext.Citas
                    .Where(c => c.MedicoId == medicoId)
                    .Include(c => c.Paciente) // includes the related foreign key data.
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add a new a register to DB
        public async Task<Medico> AddMedico(Medico model)
        {
            try
            {
                _dbContext.Medicos.Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update a register from DB
        public async Task<bool> UpdateMedico(Medico model)
        {
            try
            {
                var modelDB = await _dbContext.Medicos.FindAsync(model.MedicoId);

                if(modelDB != null)
                {
                    modelDB.EspecialidadId = model.EspecialidadId;
                    modelDB.Nombre = model.Nombre;
                    modelDB.Apellido = model.Apellido;
                    modelDB.Telefono = model.Telefono;
                    modelDB.Email = model.Email;

                    _dbContext.Medicos.Update(modelDB);
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
        public async Task<bool> DeleteMedico(int id)
        {
            try
            {
                var model = await _dbContext.Medicos.FindAsync(id);

                if (model == null)
                    return false;

                _dbContext.Medicos.Remove(model);
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
