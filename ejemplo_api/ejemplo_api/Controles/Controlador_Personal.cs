﻿using ejemplo_api.ListaDeClases;
using ejemplo_api.Modelos;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class Controlador_Personal
    {
        private HttpClient cliente;

        public Controlador_Personal()
        {
            cliente = new HttpClient();
        }
        public async Task<Lista_Personal> GetAllPersonal()
        {
            try
            {
                Lista_Personal lista_Personal = new Lista_Personal();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                lista_Personal = JsonConvert.DeserializeObject<Lista_Personal>(responseJson);
                return lista_Personal;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Personal> GetPersonal(string id)
        {
            try
            {
                Personal Personal = new Personal();
                HttpResponseMessage response = await
                    cliente.GetAsync("http://localhost:8080/perfile/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                Personal = JsonConvert.DeserializeObject<Personal>(responseJson);
                return Personal;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
