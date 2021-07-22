using BlazorFront.Models.Response;
using BlazorFront.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFront.Services.Respository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly HttpClient _http;
        protected readonly string pathURL = "https://localhost:44315/api/";
      
        public Repository(HttpClient http) => _http = http;

        public async Task<Respuesta<T>> Delete(string url, int Id)
        {
            var response = await _http.DeleteAsync(pathURL + url + Id);
            return response.Content.ReadFromJsonAsync<Respuesta<T>>().Result;
        }

        public async Task<Respuesta<T>> Get(string url, int Id)
        {
            return await _http.GetFromJsonAsync<Respuesta<T>>(pathURL+url+Id);
        }

        public async Task<Respuesta<List<T>>> GetAll(string url)
        {
            return await _http.GetFromJsonAsync <Respuesta<List<T>>> (pathURL+url);
        }

        public async Task<Respuesta<T>> Store(string url, T entity)
        {
            var response = await _http.PostAsJsonAsync<T>(pathURL + url, entity);
            return response.Content.ReadFromJsonAsync<Respuesta<T>>().Result;
        }

        public async Task<Respuesta<T>> Update(string url, T entity, int Id)
        {
            var response = await _http.PutAsJsonAsync<T>(pathURL + url + Id, entity);
            return response.Content.ReadFromJsonAsync<Respuesta<T>>().Result;
        }
    }
}
