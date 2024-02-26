
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_api.Controles
{
    class Controlador_Comentario
    {
        private HttpClient cliente;

        public Controlador_Comentario()
        {
            cliente = new HttpClient();
        }
        public async Task<List<Comentario>> GetAllComentarios()
        {
            try
            {
                List<Comentario> lista_Comentario = new List<Comentario>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/coment/comentarios");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Comentario = JsonConvert.DeserializeObject<List<Comentario>>(responseJson);
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
                    cliente.GetAsync("http://localhost:8080/coment/" + id);
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

        public async Task<Comentario> PostIncidencia(Comentario nuevoComentario)
        {
            try
            {

                var json = JsonConvert.SerializeObject(nuevoComentario);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await
                    cliente.PostAsync("http://localhost:8080/coment", stringContent);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();
                Debug.WriteLine(response);
                MessageBox.Show(responseJson);
                return nuevoComentario;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
