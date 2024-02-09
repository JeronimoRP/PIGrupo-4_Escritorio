using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Comentario
    {
        private HttpClient cliente;

        public Controlador_Comentario()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Comentario> GetAllComentarios()
        {
            try
            {
                Lista_Comentario lista_Comentario = new Lista_Comentario();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Comentario = JsonConvert.DeserializeObject<Lista_Comentario>(responseJson);
                return lista_Comentario;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Comentario> GetComentario(string id)
        {
            try
            {
                Comentario Comentario = new Comentario();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Comentario = JsonConvert.DeserializeObject<Comentario>(responseJson);
                return Comentario;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
