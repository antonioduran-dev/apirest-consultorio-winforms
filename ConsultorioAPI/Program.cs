using ConsultorioAPI.Services;
using ConsultorioAPI.Utils;
using DB.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options => // avoid the cyclic calls in JSON serialization
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.WriteIndented = true;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DBContext to use SQL Server
builder.Services.AddDbContext<ConsultorioDBContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection"))
);

// inject class Utilities
builder.Services.AddSingleton<Utilities>();

// inject services
builder.Services.AddScoped<IEspecialidadService, EspecialidadService>();
builder.Services.AddScoped<IPacienteService, PacienteService>();
builder.Services.AddScoped<IMedicoService, MedicoService>();
builder.Services.AddScoped<ICitaService, CitaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

// set endpoints to lowercase
builder.Services.AddRouting(routing => routing.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
