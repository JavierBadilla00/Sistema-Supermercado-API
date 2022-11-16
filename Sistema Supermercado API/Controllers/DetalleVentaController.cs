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
    public class DetalleVentaController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public DetalleVentaController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<DetalleVenta> Get()
        {
            return context.DetalleVenta.ToList();
        }
        [HttpGet("{string}", Name = "detalleventa Creada")]
        public IActionResult GetById(string id)
        {
            var detalleventa = context.DetalleVenta.FirstOrDefault(x => x.Id == id);
            if (detalleventa == null)
            {
                return NotFound();
            }
            return Ok(detalleventa);
        }
        [HttpPost]
        public IActionResult Post([FromBody] DetalleVenta detalleventa)
        {
            if (ModelState.IsValid)
            {
                context.DetalleVenta.Add(detalleventa);
                context.SaveChanges();
                return new CreatedAtRouteResult("detalleventa Creada",
                new { id = detalleventa.Id }, detalleventa);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DetalleVenta detalleventa, string id)
        {
            if (detalleventa.Id != id)
            {
                return BadRequest();
            }
            context.Entry(detalleventa).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var detalleventa = context.DetalleVenta.FirstOrDefault(x => x.Id == id);
            if (detalleventa == null)
            {
                return NotFound();
            }
            context.DetalleVenta.Remove(detalleventa);
            context.SaveChanges();
            return Ok(detalleventa);
        }
    }
}


