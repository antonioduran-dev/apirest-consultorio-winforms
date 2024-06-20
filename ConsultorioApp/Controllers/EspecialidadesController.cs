using DB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioApp.Controllers
{
    public class EspecialidadesController
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:5143/api/";
        public EspecialidadesController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Especialidad>> GetEspecialidades()
        {
            try
            {
                IEnumerable<Especialidad> especialidades;

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "especialidad");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                especialidades = JsonConvert.DeserializeObject<IEnumerable<Especialidad>>(responseJson);

                return especialidades;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Especialidad> GetEspecialidad(int id)
        {
            try
            {
                var especialidad = new Especialidad();

                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "especialidad/" + id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                especialidad = JsonConvert.DeserializeObject<Especialidad>(responseJson);

                return especialidad;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Especialidad> AddEspecialidad(Especialidad especialidad)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(especialidad), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "especialidad", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();
                // deserialize Json string to object Class.
                especialidad = JsonConvert.DeserializeObject<Especialidad>(responseJson);

                return especialidad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateEspecialidad(Especialidad especialidad)
        {
            try
            {

                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(especialidad), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "especialidad", content);

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

        public async Task<bool> DeleteEspecialidad(int id)
        {
            try
            {

                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "especialidad/" + id);

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
