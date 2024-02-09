using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Aula
    {
        private HttpClient cliente;

        public Controlador_Aula()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Aulas> GetAllAulas()
        {
            try
            {
                Lista_Aulas lista_Aulas = new Lista_Aulas();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Aulas = JsonConvert.DeserializeObject<Lista_Aulas>(responseJson);
                return lista_Aulas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Aula> GetAula(string num)
        {
            try
            {
                Aula aula = new Aula();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + num);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                aula = JsonConvert.DeserializeObject<Aula>(responseJson);
                return aula;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
