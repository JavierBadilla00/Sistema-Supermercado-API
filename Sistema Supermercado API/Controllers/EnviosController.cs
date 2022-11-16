using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Supermercado_API.Entity;

namespace Sistema_Supermercado_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnviosController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public EnviosController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Envios> Get()
        {
            return context.Envios.ToList();
        }
        [HttpGet("{string}", Name = "envio Creada")]
        public IActionResult GetById(string id)
        {
            var envio = context.Envios.FirstOrDefault(x => x.Id == id);
            if (envio == null)
            {
                return NotFound();
            }
            return Ok(envio);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Envios envio)
        {
            if (ModelState.IsValid)
            {
                context.Envios.Add(envio);
                context.SaveChanges();
                return new CreatedAtRouteResult("envio Creada",
                new { id = envio.Id }, envio);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Envios envio, string id)
        {
            if (envio.Id != id)
            {
                return BadRequest();
            }
            context.Entry(envio).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var envio = context.Envios.FirstOrDefault(x => x.Id == id);
            if (envio == null)
            {
                return NotFound();
            }
            context.Envios.Remove(envio);
            context.SaveChanges();
            return Ok(envio);
        }
    }
}


