using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Incidencias
    {
        private HttpClient cliente;

        public Controlador_Incidencias()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Incidencias> GetAllIncidencias()
        {
            try
            {
                Lista_Incidencias lista_Incidencias = new Lista_Incidencias();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<Lista_Incidencias>(responseJson);
                return lista_Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Incidencias> GetIncidencia(string num)
        {
            try
            {
                Incidencias Incidencias = new Incidencias();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + num);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Incidencias = JsonConvert.DeserializeObject<Incidencias>(responseJson);
                return Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
