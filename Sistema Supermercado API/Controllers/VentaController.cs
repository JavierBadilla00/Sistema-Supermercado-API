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
    public class VentaController : ControllerBase
    {
        private readonly SupermercadoBDContext context;
        public VentaController(SupermercadoBDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Venta> Get()
        {
            return context.Venta.ToList();
        }
        [HttpGet("{id}", Name = "venta Creada")]
        public IActionResult GetById(int id)
        {
            var venta = context.Venta.FirstOrDefault(x => x.Id == id);
            if (venta == null)
            {
                return NotFound();
            }
            return Ok(venta);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Venta venta)
        {
            if (ModelState.IsValid)
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return new CreatedAtRouteResult("venta Creada",
                new { id = venta.Id }, venta);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Venta venta, int id)
        {
            if (venta.Id != id)
            {
                return BadRequest();
            }
            context.Entry(venta).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var venta = context.Venta.FirstOrDefault(x => x.Id == id);
            if (venta == null)
            {
                return NotFound();
            }
            context.Venta.Remove(venta);
            context.SaveChanges();
            return Ok(venta);
        }
    }
}

