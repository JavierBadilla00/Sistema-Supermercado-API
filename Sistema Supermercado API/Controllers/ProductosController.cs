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
    public class ProductosController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public ProductosController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Productos> Get()
        {
            return context.Productos.ToList();
        }
        [HttpGet("{string}", Name = "producto Creada")]
        public IActionResult GetById(string id)
        {
            var producto = context.Productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Productos producto)
        {
            if (ModelState.IsValid)
            {
                context.Productos.Add(producto);
                context.SaveChanges();
                return new CreatedAtRouteResult("producto Creada",
                new { id = producto.Id }, producto);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Productos producto, string id)
        {
            if (producto.Id != id)
            {
                return BadRequest();
            }
            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var producto = context.Productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            context.Productos.Remove(producto);
            context.SaveChanges();
            return Ok(producto);
        }
    }
}


