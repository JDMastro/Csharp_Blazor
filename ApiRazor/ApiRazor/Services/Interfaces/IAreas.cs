using ApiRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Services.Interfaces
{
    public interface IAreas : IRepository<Areas>
    {
        Task<Areas> GetByIdSp(int id);
        Task<List<Areas>> GetAreasSp();
        Task<Areas> InsertAreasSp(Areas a);
        Task<Areas> ActualizarAreasSp(Areas a);
    }
}
