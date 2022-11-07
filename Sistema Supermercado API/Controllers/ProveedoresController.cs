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
    public class ProveedoresController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public ProveedoresController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Proveedores> Get()
        {
            return context.Proveedores.ToList();
        }
        [HttpGet("{string}", Name = "proveedore Creada")]
        public IActionResult GetById(string id)
        {
            var proveedore = context.Proveedores.FirstOrDefault(x => x.Id == id);
            if (proveedore == null)
            {
                return NotFound();
            }
            return Ok(proveedore);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Proveedores proveedore)
        {
            if (ModelState.IsValid)
            {
                context.Proveedores.Add(proveedore);
                context.SaveChanges();
                return new CreatedAtRouteResult("proveedore Creada",
                new { id = proveedore.Id }, proveedore);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Proveedores proveedore, string id)
        {
            if (proveedore.Id != id)
            {
                return BadRequest();
            }
            context.Entry(proveedore).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var proveedore = context.Proveedores.FirstOrDefault(x => x.Id == id);
            if (proveedore == null)
            {
                return NotFound();
            }
            context.Proveedores.Remove(proveedore);
            context.SaveChanges();
            return Ok(proveedore);
        }
    }
}


