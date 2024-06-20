using DB.Models;
using Newtonsoft.Json;
using System.Text;


namespace ConsultorioApp.Controllers
{
    public class MedicosController
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/";
        public MedicosController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Medico>> GetMedicos()
        {
            try
            {
                IEnumerable<Medico> medicos;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"medico");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                medicos = JsonConvert.DeserializeObject<IEnumerable<Medico>>(responseJson);

                return medicos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Medico> GetMedico(int id)
        {
            try
            {
                var medico = new Medico();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "medico/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                medico = JsonConvert.DeserializeObject<Medico>(responseJson);

                return medico;
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
                Medico medico;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + $"medico/{usuarioId}/usuario");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                medico = JsonConvert.DeserializeObject<Medico>(responseJson);

                return medico;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Cita>> GetCitasByMedicoId(int medicoId)
        {
            try
            {
                IEnumerable<Cita> citas;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + $"medico/{medicoId}/citas");

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

        public async Task<Medico> AddMedico(Medico medico)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(medico), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "medico", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                medico = JsonConvert.DeserializeObject<Medico>(responseJson);

                return medico;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateMedico(Medico medico)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(medico), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "medico/", content);

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

        public async Task<bool> DeleteMedico(int id)
        {
            try
            {

                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "medico/"+id);

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
