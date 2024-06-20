using System.Text.Json.Serialization;

namespace DB.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
