
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public async Task<List<Aula>> GetAllAulas()
        {
            try
            {
                List<Aula> lista_Aulas = new List<Aula>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/api/aulas");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Aulas = JsonConvert.DeserializeObject<List<Aula>>(responseJson);
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
                    cliente.GetAsync("http://localhost:8080/api/" + num);
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
