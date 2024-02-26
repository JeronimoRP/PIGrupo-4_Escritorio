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
    class Controlador_Incidencias
    {
        private HttpClient cliente;

        public Controlador_Incidencias()
        {
            cliente = new HttpClient();
        }
        public async Task<List<Incidencias>> GetAllIncidencias()
        {
            
                List<Incidencias> lista_Incidencias = new List<Incidencias>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/ap/incidencias");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                return lista_Incidencias;
            
        }
        public async Task<List<Incidencias>> GetAllIncidenciasbyId(string id)
        {
            try
            {
                List<Incidencias> lista_Incidencias = new List<Incidencias>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/ap/creador/"+id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                return lista_Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Incidencias>> GetAllSubSubtipos(string nombre)
        {
            try
            {
                List<Incidencias> lista_Incidencias = new List<Incidencias>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/ap/subtipo/nombre/" + nombre);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
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
                    cliente.GetAsync("http://localhost:8080/ap/" + num);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();
                MessageBox.Show(responseJson);
                Incidencias = JsonConvert.DeserializeObject<Incidencias>(responseJson);
                return Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Incidencias>> GetAllIncidenciasPorFiltro(string tipo, string estado,string subtipo)
        {
            try
            {
                List<Incidencias> lista_Incidencias = new List<Incidencias>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/ap/filtro?tipo="+tipo+"&estado="+estado+"&subtipoNombre="+subtipo);
                response.EnsureSuccessStatusCode();
                
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                return lista_Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Incidencias>> GetAllIncidenciasPorFiltro(string tipo, string estado, string subtipo, string fechaCreacion)
        {
            try
            {
                List<Incidencias> lista_Incidencias = new List<Incidencias>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/ap/filtro?tipo=" + tipo + "&estado=" + estado + "&subtipoNombre=" + subtipo + "&fechaCreacion=" + fechaCreacion);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Incidencias = JsonConvert.DeserializeObject<List<Incidencias>>(responseJson);
                return lista_Incidencias;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Incidencias> PostIncidencia(Incidencias incidencia)
        {
            try
            {
                var json = JsonConvert.SerializeObject(incidencia);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await cliente.PostAsync("http://localhost:8080/ap", stringContent);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();
                Debug.WriteLine(response);
                MessageBox.Show(responseJson);
                return incidencia;
            }
            catch (HttpRequestException ex)
            {
                // Manejar la excepción HttpRequestException
                Console.WriteLine($"Error de solicitud HTTP: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                Console.WriteLine($"Error inesperado: {ex.Message}");
                return null;
            }

        }


        public async Task<Incidencias> DeleteIncidencias(Incidencias inc ,string id)
        {
            try
            {

                HttpResponseMessage response = await
                    cliente.DeleteAsync("http://localhost:8080/ap/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                //personajes = JsonConvert.DeserializeObject<Character>(responseJson);
                MessageBox.Show(responseJson);
                return inc;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
