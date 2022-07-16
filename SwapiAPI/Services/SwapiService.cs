using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwapiAPI.Models;

namespace SwapiAPI.Services
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public string baseURL = "https://swapi.dev/api/people/";

        public async Task<Person> GetPersonAsync(int id)
        {
            HttpResponseMessage response = _httpClient.GetAsync(baseURL+id).Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;

                Person person = JsonConvert.DeserializeObject<Person>(content);

                return person;
            }

            return null;
        }

        public async Task<T> GetAsync<T>(string url) where T: class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                T content = await response.Content.ReadAsAsync<T>();

                return content;
            }

            return null;
        }

    }
}