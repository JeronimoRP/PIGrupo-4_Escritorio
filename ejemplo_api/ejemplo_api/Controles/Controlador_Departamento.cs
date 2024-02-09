using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Departamento
    {
        private HttpClient cliente;

        public Controlador_Departamento()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Departamento> GetAllDepartamentos()
        {
            try
            {
                Lista_Departamento lista_Departamento = new Lista_Departamento();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Departamento = JsonConvert.DeserializeObject<Lista_Departamento>(responseJson);
                return lista_Departamento;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Departamento> GetDepartamento(string id)
        {
            try
            {
                Departamento Departamento = new Departamento();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Departamento = JsonConvert.DeserializeObject<Departamento>(responseJson);
                return Departamento;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
