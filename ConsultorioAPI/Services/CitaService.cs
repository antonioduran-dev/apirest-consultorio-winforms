using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Services
{
    public class CitaService : ICitaService
    {
        private readonly ConsultorioDBContext _dbContext;
        public CitaService(ConsultorioDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // get all registers from DB
        public async Task<IEnumerable<Cita>> GetCitas()
        {
            try
            {
                return await _dbContext.Citas
                    .Include(p => p.Paciente) // includes the related foreign key data.
                    .Include(m => m.Medico)
                    .ThenInclude(m => m.Especialidad) // includes another related foreign key data.
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get a register from DB by id
        public async Task<Cita> GetCita(int id)
        {
            try
            {
                return await _dbContext.Citas
                    .Include(p => p.Paciente) // includes the related foreign key data.
                    .Include(m => m.Medico)
                    .ThenInclude(m => m.Especialidad) // includes another related foreign key data.
                    .FirstOrDefaultAsync(c => c.CitaId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add a new a register to DB
        public async Task<Cita> AddCita(Cita model)
        {
            try
            {
                _dbContext.Citas.Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update a register from DB
        public async Task<bool> UpdateCita(Cita model)
        {
            try
            {
                var modelDB = await _dbContext.Citas.FindAsync(model.CitaId);

                if(modelDB != null)
                {
                    modelDB.PacienteId = model.PacienteId;
                    modelDB.MedicoId = model.MedicoId;
                    modelDB.FechaCita = model.FechaCita;
                    modelDB.HoraCita = model.HoraCita;
                    modelDB.MotivoCita = model.MotivoCita;

                    _dbContext.Citas.Update(modelDB);
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
        public async Task<bool> DeleteCita(int id)
        {
            try
            {
                var model = await _dbContext.Citas.FindAsync(id);

                if (model == null)
                    return false;

                _dbContext.Citas.Remove(model);
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
