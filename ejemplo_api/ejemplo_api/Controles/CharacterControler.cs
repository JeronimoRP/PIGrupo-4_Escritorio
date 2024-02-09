using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_api.Controles
{
    class CharacterControler
    {
        /*
        private HttpClient cliente;

        public CharacterControler()
        {
            cliente = new HttpClient();
        }

        public async Task<Characters> GetAllCharacters()
        {
            try
            {
                Characters personajes = new Characters();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Characters>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<Character> GetAllCharactersByName(string nombre)
        {
            try
            {
                Character personajes = new Character();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character?name=" + nombre);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Character>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<Character> GetAllCharactersById(string id)
        {
            try
            {
                Character personajes = new Character();
                HttpResponseMessage response = await
                    cliente.GetAsync("https://rickandmortyapi.com/api/character/" + id);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Character>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<Character> PutCharacters(Character personajes)
        {

            var json = JsonConvert.SerializeObject(personajes);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await
                cliente.PutAsync("https://httpbin.org/put", null);
            response.EnsureSuccessStatusCode();
            string responseJson = await
                response.Content.ReadAsStringAsync();

            //personajes = JsonConvert.DeserializeObject<Character>(responseJson);
            MessageBox.Show(responseJson);
            return personajes;

        }


        public async Task<Character> PostCharacters(Character personajes)
        {
            try
            {

                var json = JsonConvert.SerializeObject(personajes);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await
                    cliente.PostAsync("https://httpbin.org/post", null);
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                //personajes = JsonConvert.DeserializeObject<Character>(responseJson);
                MessageBox.Show(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public async Task<Character> DeleteCharacters(Character personajes)
        {
            try
            {

                var json = JsonConvert.SerializeObject(personajes);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await
                    cliente.DeleteAsync("https://httpbin.org/delete");
                response.EnsureSuccessStatusCode();
                string responseJson = await
                    response.Content.ReadAsStringAsync();

                //personajes = JsonConvert.DeserializeObject<Character>(responseJson);
                MessageBox.Show(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }

        }*/
    }
}
