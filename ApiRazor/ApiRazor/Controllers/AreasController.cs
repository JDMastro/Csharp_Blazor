using ApiRazor.Models;
using ApiRazor.Models.Response;
using ApiRazor.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace ApiRazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreasController : Controller
    {
        private readonly IAreas areasRepository;
        public AreasController(IAreas areas) => areasRepository = areas;

        [HttpGet("empleados")]
        public async Task<ActionResult> GetAreasEmpleados()
        {
            var respuesta = new Respuesta<List<Areas>>();
            try
            {
                respuesta.Exito = 1;
                var res = await areasRepository.GetAreasSp();
                respuesta.Data = res.Where(a => a.TrabajadoresId > 0).ToList();
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpGet("jefes")]
        public async Task<ActionResult> GetAreasJefes()
        {
            var respuesta = new Respuesta<List<Areas>>();
            try
            {
                respuesta.Exito = 1;
                var res = await areasRepository.GetAreasSp();
                respuesta.Data = res.Where(a => a.TrabajadoresId == 0).ToList();
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpGet]
        public async Task<ActionResult> GetAreas()
        {
            var respuesta = new Respuesta<List<Areas>>();
            try {
                respuesta.Exito = 1;
                respuesta.Data = await areasRepository.GetAreasSp();
            }catch(Exception ex) {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> GetArea(int id)
        {
            var respuesta = new Respuesta<Areas>();
            try
            {
                respuesta.Exito = 1;
                respuesta.Data = await areasRepository.GetByIdSp(id);
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPost]
        public async Task<ActionResult> AddAreaSp([FromBody] Areas a)
        {
            var respuesta = new Respuesta<Areas>();
            try
            {

                await areasRepository.InsertAreasSp(a);
                respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAreas(int id, [FromBody] Areas a)
        {
            var respuesta = new Respuesta<Areas>();
            if (a.Id == id)
            {
                try
                {
                    await areasRepository.ActualizarAreasSp(a);
                    respuesta.Exito = 1;
                }
                catch (Exception ex) {

                    respuesta.Mensaje = ex.Message;
                }

                return Ok(respuesta);
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
