using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    public class Controlador_Perfiles
    {
        private HttpClient cliente;

        public Controlador_Perfiles()
        {
            cliente = new HttpClient();
        }

        public async Task<List<Perfiles>> GetAllPerfiles()
        {
            try
            {
                List<Perfiles> personajes = new List<Perfiles>();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<List<Perfiles>>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }
       
        public async Task<Perfiles> GetPerfil(string dominio)
        {
            try
            {
                Perfiles personajes = new Perfiles();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + dominio);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Perfiles>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
