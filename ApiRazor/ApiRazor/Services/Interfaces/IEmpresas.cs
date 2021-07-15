using ApiRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Services.Interfaces
{
    public interface IEmpresas : IRepository<Empresas>
    {
        Task<List<Empresas>> ObtenerEmpresasSp();
    }
}
