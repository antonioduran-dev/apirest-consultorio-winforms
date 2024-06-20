using DB.Models;
using Newtonsoft.Json;
using System.Text;


namespace ConsultorioApp.Controllers
{
    public class CitasController
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/";
        public CitasController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Cita>> GetCitas()
        {
            try
            {
                IEnumerable<Cita> citas;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"cita");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                citas = JsonConvert.DeserializeObject<IEnumerable<Cita>>(responseJson);

                return citas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Cita> GetCita(int id)
        {
            try
            {
                var cita = new Cita();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "cita/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                cita = JsonConvert.DeserializeObject<Cita>(responseJson);

                return cita;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cita> AddCita(Cita cita)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(cita), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "cita", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                cita = JsonConvert.DeserializeObject<Cita>(responseJson);

                return cita;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateCita(Cita cita)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(cita), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "cita", content);

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

        public async Task<bool> DeleteCita(int id)
        {
            try
            {

                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "cita/"+id);

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
