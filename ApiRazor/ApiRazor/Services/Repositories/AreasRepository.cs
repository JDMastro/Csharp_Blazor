using ApiRazor.Data;
using ApiRazor.Models;
using ApiRazor.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Services.Repositories
{
    public class AreasRepository : Repository<Areas>, IAreas
    {
        public AreasRepository(AppDbContext context) : base(context) { }

        public async Task<Areas> ActualizarAreasSp(Areas a)
        {
            var Vdescripcion = new MySqlParameter("@Vdescripcion", a.Descripcion);
            var Vid = new MySqlParameter("@Vid", a.Id);
            var res = await Context.Areas.FromSqlRaw("call SpActualizarArea(@Vid, @Vdescripcion)", parameters: new[] { Vid, Vdescripcion }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<List<Areas>> GetAreasSp()
        {
            return await Context.Areas.FromSqlRaw("call test.SpObtenerAreas").ToListAsync();
        }

        public async Task<Areas> GetByIdSp(int id)
        {
            var Vid = new MySqlParameter("@Vid", id);
            var res = await Context.Areas.FromSqlRaw("call test.SpObtenerPorId(@Vid)", parameters: new[] { Vid }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<Areas> InsertAreasSp(Areas a)
        {
            var Vdescripcion = new MySqlParameter("@Vdescripcion", a.Descripcion);
            var res = await Context.Areas.FromSqlRaw("call test.SpInsertarAreas(@Vdescripcion)", parameters: new[] { Vdescripcion }).ToListAsync();
            return res.FirstOrDefault();
        }
    }
}
