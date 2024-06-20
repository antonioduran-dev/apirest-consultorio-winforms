using DB.Models;
using Newtonsoft.Json;
using System.Text;


namespace ConsultorioApp.Controllers
{
    public class UsuariosController
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/";

        public UsuariosController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            try
            {
                IEnumerable<Usuario> usuarios;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"usuario");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                usuarios = JsonConvert.DeserializeObject<IEnumerable<Usuario>>(responseJson);

                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            try
            {
                var Usuario = new Usuario();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "usuario/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                Usuario = JsonConvert.DeserializeObject<Usuario>(responseJson);

                return Usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetUsuarioByUsername(string username)
        {
            try
            {
                var Usuario = new Usuario();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + $"usuario/username?username={username}");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                Usuario = JsonConvert.DeserializeObject<Usuario>(responseJson);

                return Usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> AddUsuario(Usuario usuario)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "usuario", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                usuario = JsonConvert.DeserializeObject<Usuario>(responseJson);

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateUsuario(Usuario usuario)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "usuario/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteUsuario(int id)
        {
            try
            {

                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "usuario/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
