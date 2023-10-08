using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wsApi.Db;
using wsApi.Models;

namespace wsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly context _context;

        public PersonaController(context context)
        {
            this._context = context;
        }

        [HttpGet("Inicio")]
        public ActionResult Index()
        {
            return Ok("TODO LISTO !!!!");
        }

        [HttpGet("List")]
        public async Task<ActionResult<List<Persona>>> GetAllPersona()
        {
            try
            {
                var query = await _context.Personas.ToListAsync();
                return Ok(query);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "ha ocurrido un error " + ex.Message);
            }
        }

        [HttpGet("GetPersona")]
        public async Task<ActionResult> GetPersona(int personaId)
        {
            try
            {
                var query = await _context.Personas.Where(x => x.personaId == personaId).FirstOrDefaultAsync();
                return Ok(query);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "ha ocurrido un error " + ex.Message);
            }
        }

        [HttpPost("PostPersona")]
        public async Task<ActionResult> PostPersona(Persona persona) 
        {
            try
            {
                _context.Personas.Add(persona);
                await _context.SaveChangesAsync();
                return Ok("Se ha agregado una nueva persona !!!");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "ha ocurrido un error " + ex.Message);
            }
        }

    }
}
