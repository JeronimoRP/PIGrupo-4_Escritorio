using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
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
        public async Task<Lista_Incidencias_Subtipo> GetAllIncidenciasSubtipos()
        {
            try
            {
                Lista_Incidencias_Subtipo Lista_Incidencias_Subtipo = new Lista_Incidencias_Subtipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Lista_Incidencias_Subtipo = JsonConvert.DeserializeObject<Lista_Incidencias_Subtipo>(responseJson);
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
                    cliente.GetAsync("http://localhost:8080/perfile/" + id);
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
