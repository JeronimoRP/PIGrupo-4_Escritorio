
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public async Task<List<Equipo>> GetAllEquipos()
        {
            try
            {
                List<Equipo> lista_Equipo = new List<Equipo>();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/eq/equipos");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Equipo = JsonConvert.DeserializeObject<List<Equipo>>(responseJson);
                return lista_Equipo;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Equipo> GetEquipo(string id)
        {
            try
            {
                Equipo equipo = new Equipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/eq/" + id);
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
        public async Task<Equipo> GetEquipoPorEtiqueta(string etiqueta)
        {
            try
            {
                Equipo equipo = new Equipo();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/eq/" + etiqueta);
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
