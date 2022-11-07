using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Supermercado_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Supermercado_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTarjetaController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public TipoTarjetaController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<TipoTarjeta> Get()
        {
            return context.TipoTarjeta.ToList();
        }
        [HttpGet("{string}", Name = "tipotarjeta Creada")]
        public IActionResult GetById(string id)
        {
            var tipotarjeta = context.TipoTarjeta.FirstOrDefault(x => x.Id == id);
            if (tipotarjeta == null)
            {
                return NotFound();
            }
            return Ok(tipotarjeta);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TipoTarjeta tipotarjeta)
        {
            if (ModelState.IsValid)
            {
                context.TipoTarjeta.Add(tipotarjeta);
                context.SaveChanges();
                return new CreatedAtRouteResult("tipotarjeta Creada",
                new { id = tipotarjeta.Id }, tipotarjeta);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TipoTarjeta tipotarjeta, string id)
        {
            if (tipotarjeta.Id != id)
            {
                return BadRequest();
            }
            context.Entry(tipotarjeta).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var tipotarjeta = context.TipoTarjeta.FirstOrDefault(x => x.Id == id);
            if (tipotarjeta == null)
            {
                return NotFound();
            }
            context.TipoTarjeta.Remove(tipotarjeta);
            context.SaveChanges();
            return Ok(tipotarjeta);
        }
    }
}
