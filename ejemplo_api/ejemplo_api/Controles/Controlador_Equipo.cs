using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Equipo
    {
        private HttpClient cliente;

        public Controlador_Equipo()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Equipo> GetAllEquipos()
        {
            try
            {
                Lista_Equipo lista_Equipo = new Lista_Equipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Equipo = JsonConvert.DeserializeObject<Lista_Equipo>(responseJson);
                return lista_Equipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Equipo> Getequipo(string id)
        {
            try
            {
                Equipo equipo = new Equipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                equipo = JsonConvert.DeserializeObject<Equipo>(responseJson);
                return equipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
