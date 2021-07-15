using ApiRazor.Models;
using ApiRazor.Models.Response;
using ApiRazor.Services.Interfaces;
using ApiRazor.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrabajadoresController : Controller
    {
        private readonly ITrabajadores trabajadoresRepository;

        public TrabajadoresController(ITrabajadores trabajos) => trabajadoresRepository = trabajos;
        
        [HttpGet("/api/[controller]/empleados")]
        public async Task<IActionResult> GetEmpleados()
        {
            var respuesta = new Respuesta<List<Trabajadores>>();
            try
            {
                respuesta.Exito = 1;
                respuesta.Data = await trabajadoresRepository.GetEmpleadosSp();
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpGet("/api/[controller]/jefes")]
        public async Task<IActionResult> GetJefes()
        {
            var respuesta = new Respuesta<List<Trabajadores>>();
            try
            {
                respuesta.Exito = 1;
                respuesta.Data = await trabajadoresRepository.GetJefesSp();
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPost("/api/[controller]/empleados")]
        public async Task<IActionResult> InsertEmpleados(Trabajadores t)
        {
            var respuesta = new Respuesta<Trabajadores>();
            try
            {
                await trabajadoresRepository.InsertTrabajadoresEmpleadosSp(t);
                respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPost("/api/[controller]/jefes")]
        public async Task<IActionResult> InsertJefes(Trabajadores t)
        {
            var respuesta = new Respuesta<Trabajadores>();
            try
            {
                await trabajadoresRepository.InsertTrabajadoresEmpleadosSp(t);
                respuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmpleados(int id, [FromBody] Trabajadores t)
        {
            var respuesta = new Respuesta<Trabajadores>();
            if (t.Id == id)
            {
                try
                {
                    await trabajadoresRepository.ActualizarTrabajadoresSp(t);
                    respuesta.Exito = 1;
                }
                catch (Exception ex)
                {
                    respuesta.Mensaje = ex.Message;
                }
                return Ok(respuesta);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrabajadores (int id) 
        {
            var respuesta = new Respuesta<Trabajadores>();
            try {
                respuesta.Exito = 1;
                respuesta.Data = await trabajadoresRepository.GetTrabajadoresSp(id);
            }catch(Exception ex) {
                respuesta.Mensaje = ex.Message;
            }


            return Ok(respuesta);
        }
    }
}
