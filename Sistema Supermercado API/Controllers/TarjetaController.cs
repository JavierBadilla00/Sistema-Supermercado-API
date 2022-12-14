using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Supermercado_API.Entities;

namespace Sistema_Supermercado_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly SupermercadoBDContext context;
        public TarjetaController(SupermercadoBDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Tarjeta> Get()
        {
            return context.Tarjeta.ToList();
        }
        [HttpGet("{id}", Name = "tarjeta Creada")]
        public IActionResult GetById(int id)
        {
            var tarjeta = context.Tarjeta.FirstOrDefault(x => x.Id == id);
            if (tarjeta == null)
            {
                return NotFound();
            }
            return Ok(tarjeta);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                context.Tarjeta.Add(tarjeta);
                context.SaveChanges();
                return new CreatedAtRouteResult("tarjeta Creada",
                new { id = tarjeta.Id }, tarjeta);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Tarjeta tarjeta, int id)
        {
            if (tarjeta.Id != id)
            {
                return BadRequest();
            }
            context.Entry(tarjeta).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarjeta = context.Tarjeta.FirstOrDefault(x => x.Id == id);

            if (tarjeta == null)
            {
                return NotFound();
            }
            context.Tarjeta.Remove(tarjeta);
            context.SaveChanges();
            return Ok(tarjeta);
        }
    }
}
