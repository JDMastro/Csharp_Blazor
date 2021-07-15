using BlazorFront.Models;
using BlazorFront.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorFront.Services.Respository
{
    public class TrabajadoresRepository : Repository<Trabajadores>, ITrabajadores
    {
        public TrabajadoresRepository(HttpClient http) : base(http)
        {
        }
    }
}
