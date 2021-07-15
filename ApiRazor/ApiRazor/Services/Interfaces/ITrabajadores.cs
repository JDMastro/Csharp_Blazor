using ApiRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Services.Interfaces
{
    public interface ITrabajadores : IRepository<Trabajadores>
    {
        Task<List<Trabajadores>> GetEmpleadosSp();
        Task<List<Trabajadores>> GetJefesSp();
        Task<Trabajadores> GetTrabajadoresSp(int id);
        Task<Trabajadores> InsertTrabajadoresJefesSp(Trabajadores t);
        Task<Trabajadores> InsertTrabajadoresEmpleadosSp(Trabajadores t);
        Task<Trabajadores> ActualizarTrabajadoresSp(Trabajadores t);
    }
}
