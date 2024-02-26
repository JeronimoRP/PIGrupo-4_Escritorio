
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Incidencias_Subtipos
    {
        private HttpClient cliente;

        public Controlador_Incidencias_Subtipos()
        {
            cliente = new HttpClient();
        }
        public async Task<List<Incidencias_subtipo>> GetAllIncidenciasSubtipos()
        {
            try
            {
                List<Incidencias_subtipo> Lista_Incidencias_Subtipo = new List<Incidencias_subtipo>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/subtipos");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Lista_Incidencias_Subtipo = JsonConvert.DeserializeObject<List<Incidencias_subtipo>>(responseJson);
                return Lista_Incidencias_Subtipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Incidencias_subtipo> GetIncidenciaSubtipo(string id)
        {
            try
            {
                Incidencias_subtipo IncidenciaSubtipo = new Incidencias_subtipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/subtipos/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                IncidenciaSubtipo = JsonConvert.DeserializeObject<Incidencias_subtipo>(responseJson);
                return IncidenciaSubtipo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Incidencias_subtipo> GetIncidenciaSubtipoPorSubSubtipo(string subtipo)
        {
            try
            {
                Incidencias_subtipo IncidenciaSubtipo = new Incidencias_subtipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + subtipo);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                IncidenciaSubtipo = JsonConvert.DeserializeObject<Incidencias_subtipo>(responseJson);
                return IncidenciaSubtipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
