using BlazorFront.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorFront.Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<Respuesta<List<T>>> GetAll(string url);
        Task<Respuesta<T>> Get(string url, int Id);
        Task<Respuesta<T>> Store(string url, T entity);
        Task<Respuesta<T>> Update(string url, T entity, int Id);
    }
}
