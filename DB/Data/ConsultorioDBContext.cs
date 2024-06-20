using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB.Data
{
    // create the context to connect and create the DB.
    
    public class ConsultorioDBContext : DbContext // inherit DbContext
    {
        public ConsultorioDBContext(DbContextOptions<ConsultorioDBContext> options) : base(options)
        {
            
        }
        // add models to create entities in DB
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Define properties of entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>(tb =>
            {
                tb.HasKey(col => col.PacienteId);

                // auto increment id and generated when Add a register.
                tb.Property(col => col.PacienteId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre).HasMaxLength(100);
                tb.Property(col => col.Apellido).HasMaxLength(100);
                tb.Property(col => col.Direccion).HasMaxLength(200);
                tb.Property(col => col.Telefono).HasMaxLength(15);
                tb.Property(col => col.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<Especialidad>(tb =>
            {
                tb.HasKey(col => col.EspecialidadId);

                // auto increment id and generated when Add a register.
                tb.Property(col => col.EspecialidadId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Medico>(tb =>
            {
                tb.HasKey(col => col.MedicoId);

                // auto increment id and generated when Add a register.
                tb.Property(col => col.MedicoId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre).HasMaxLength(100);
                tb.Property(col => col.Apellido).HasMaxLength(100);
                tb.Property(col => col.Telefono).HasMaxLength(15);
                tb.Property(col => col.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<Cita>(tb =>
            {
                tb.HasKey(col => col.CitaId);

                // auto increment id and generated when Add a register.
                tb.Property(col => col.CitaId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Usuario>(tb =>
            {
                tb.HasKey(col => col.UsuarioId);

                // auto increment id and generated when Add a register.
                tb.Property(col => col.UsuarioId)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.NombreUsuario).HasMaxLength(100);
                tb.Property(col => col.Clave).HasMaxLength(200);
                tb.Property(col => col.Rol).HasMaxLength(50);
            });

            // base.OnModelCreating(modelBuilder);
        }
    }
}
