using ApiRazor.Models;
using ApiRazor.Models.Response;
using ApiRazor.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresasController : Controller
    {
        private readonly IEmpresas empresasRepository;
        public EmpresasController(IEmpresas empresas) => empresasRepository = empresas;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var respuesta = new Respuesta<List<Empresas>>();
            try
            {
                respuesta.Exito = 1;
                respuesta.Data = await empresasRepository.ObtenerEmpresasSp();
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }
    }
}
