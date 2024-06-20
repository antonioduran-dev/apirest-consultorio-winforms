using DB.Models;
using Newtonsoft.Json;
using System.Text;


namespace ConsultorioApp.Controllers
{
    public class PacientesController
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/";
        public PacientesController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            try
            {
                IEnumerable<Paciente> pacientes;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"paciente");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                pacientes = JsonConvert.DeserializeObject<IEnumerable<Paciente>>(responseJson);

                return pacientes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Paciente> GetPaciente(int id)
        {
            try
            {
                var paciente = new Paciente();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "paciente/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                paciente = JsonConvert.DeserializeObject<Paciente>(responseJson);

                return paciente;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Paciente> AddPaciente(Paciente paciente)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(paciente), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "paciente", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                paciente = JsonConvert.DeserializeObject<Paciente>(responseJson);

                return paciente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdatePaciente(Paciente paciente)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(paciente), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "paciente/", content);

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

        public async Task<bool> DeletePaciente(int id)
        {
            try
            {

                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "paciente/"+id);

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
