using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly ConsultorioDBContext _dbContext;
        public PacienteService(ConsultorioDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // get all registers from DB
        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            try
            {
                return await _dbContext.Pacientes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get a register from DB by id
        public async Task<Paciente> GetPaciente(int id)
        {
            try
            {
                return await _dbContext.Pacientes.FirstOrDefaultAsync(p => p.PacienteId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add a new a register to DB
        public async Task<Paciente> AddPaciente(Paciente model)
        {
            try
            {
                _dbContext.Pacientes.Add(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update a register from DB
        public async Task<bool> UpdatePaciente(Paciente model)
        {
            try
            {
                var modelDB = await _dbContext.Pacientes.FindAsync(model.PacienteId);

                if(modelDB != null)
                {
                    modelDB.Nombre = model.Nombre;
                    modelDB.Apellido = model.Apellido;
                    modelDB.FechaNacimiento = model.FechaNacimiento;
                    modelDB.Genero = model.Genero;
                    modelDB.Direccion = model.Direccion;
                    modelDB.Telefono = model.Telefono;
                    modelDB.Email = model.Email;

                    _dbContext.Pacientes.Update(modelDB);
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
        public async Task<bool> DeletePaciente(int id)
        {
            try
            {
                var model = await _dbContext.Pacientes.FindAsync(id);

                if (model == null)
                    return false;

                _dbContext.Pacientes.Remove(model);
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
