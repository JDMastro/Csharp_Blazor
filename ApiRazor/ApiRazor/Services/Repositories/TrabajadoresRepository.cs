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
    public class TrabajadoresRepository : Repository<Trabajadores>, ITrabajadores
    {
        public TrabajadoresRepository(AppDbContext context) : base(context) { }

        public async Task<Trabajadores> ActualizarTrabajadoresSp(Trabajadores t)
        {
            var Vid = new MySqlParameter("@Vid", t.Id);
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);

            var res = await Context.Trabajadores.FromSqlRaw("call test.SpUpdateTrabajadorJefe(@Vid,@Vnombres,@Vapellidos,@Vdireccion,@Vtelefono,@Vsalario)",
                parameters: new[] { Vid, Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<Trabajadores> EliminarJefesSp(int id)
        {
            var Vid = new MySqlParameter("@Vid", id);
            var res = await Context.Trabajadores.FromSqlRaw("call test.SpEliminarTrabajadorJefe(@Vid);", parameters: new[] { Vid }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<Trabajadores> EliminarTrabajadoresSp(int id)
        {
            var Vid = new MySqlParameter("@Vid", id);
            var res = await Context.Trabajadores.FromSqlRaw("call test.SpEliminarTrabajadorNormal(@Vid);", parameters: new[] { Vid }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<List<Trabajadores>> GetEmpleadosSp()
        {
            return await Context.Trabajadores.FromSqlRaw("call test.SpObtenerTrabajadorEmpleados();").ToListAsync();
        }

        public async Task<List<Trabajadores>> GetJefesSp()
        {
            return await Context.Trabajadores.FromSqlRaw("call test.SpObtenerTrabajadorJefe();").ToListAsync();
        }

        public async Task<Trabajadores> GetTrabajadoresSp(int id)
        {
            var Vid = new MySqlParameter("@Vid", id);
            var res = await Context.Trabajadores.FromSqlRaw("call test.SpObtenerTrabajadorId(@Vid);", parameters: new[] { Vid }).ToListAsync();
            return res.FirstOrDefault();
        }

        public async Task<Trabajadores> InsertTrabajadoresEmpleadosSp(Trabajadores t)
        {
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);
            var VareasId = new MySqlParameter("@VareasId", t.AreasId);
            var VfechaIngreso = new MySqlParameter("@VfechaIngreso", t.FechaIngreso);
            var Vsexo = new MySqlParameter("@Vsexo", t.Sexo);
            var VempresasId = new MySqlParameter("@VempresasId", t.EmpresasId);

            var res = await Context.Trabajadores.FromSqlRaw("call test.SpInsertarTrabajadorNormal(@Vnombres, @Vapellidos, @Vdireccion, @Vtelefono, @Vsalario, @VareasId, @VfechaIngreso, @Vsexo, @VempresasId);",
                parameters: new[] { Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso, Vsexo, VempresasId }).ToListAsync();

            return res.FirstOrDefault();
        }

        public async Task<Trabajadores> InsertTrabajadoresJefesSp(Trabajadores t)
        {
            var Vnombres = new MySqlParameter("@Vnombres", t.Nombres);
            var Vapellidos = new MySqlParameter("@Vapellidos", t.Apellidos);
            var Vdireccion = new MySqlParameter("@Vdireccion", t.Direccion);
            var Vtelefono = new MySqlParameter("@Vtelefono", t.Telefono);
            var Vsalario = new MySqlParameter("@Vsalario", t.Salario);
            var VareasId = new MySqlParameter("@VareasId", t.AreasId);
            var VfechaIngreso = new MySqlParameter("@VfechaIngreso", t.FechaIngreso);
            var Vsexo = new MySqlParameter("@Vsexo", t.Sexo);
            var VempresasId = new MySqlParameter("@VempresasId", t.EmpresasId);

            var res = await Context.Trabajadores.FromSqlRaw("call test.SpInsertarTrabajadorJefe(@Vnombres, @Vapellidos, @Vdireccion, @Vtelefono, @Vsalario, @VareasId, @VfechaIngreso, @Vsexo, @VempresasId);",
                parameters: new[] { Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso, Vsexo, VempresasId }).ToListAsync();

            return res.FirstOrDefault();
        }
    }
}
