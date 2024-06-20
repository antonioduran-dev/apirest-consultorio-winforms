using ConsultorioAPI.Utils;
using DB.Models;
using System.Net.Http.Json;


namespace ConsultorioApp.Controllers
{
    internal class LoginUserController
    {
        Utilities _utils;
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/usuario/";
        public LoginUserController()
        {
            _httpClient = new HttpClient();
            _utils = new Utilities();
        }

        public async Task<Usuario> AuthenticateUser(string username, string password)
        {
            try
            {

                // Solicita el usuario por nombre de usuario
                var response = await _httpClient.GetAsync(_url + $"username?username={username}");
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var user = await response.Content.ReadFromJsonAsync<Usuario>();

                if (user == null || _utils.EncriptarSHA256(password) != user.Clave)
                {
                    return null;
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
