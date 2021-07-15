using ApiRazor.Data;
using ApiRazor.Models;
using ApiRazor.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Services.Repositories
{
    public class EmpresasRepository : Repository<Empresas>, IEmpresas
    {
        public EmpresasRepository(AppDbContext context) : base(context) { }

        public async Task<List<Empresas>> ObtenerEmpresasSp()
        {
            return await Context.Empresas.FromSqlRaw("call test.SpObtenerEmpresas()").ToListAsync();
        }
    }
}
