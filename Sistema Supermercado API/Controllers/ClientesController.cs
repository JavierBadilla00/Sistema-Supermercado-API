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
    public  class ClientesController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public ClientesController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Clientes> Get()
        {
            return context.Clientes.ToList();
        }
        [HttpGet("{string}", Name = "cliente Creada")]
        public IActionResult GetById(string id)
        {
            var clientes = context.Clientes.FirstOrDefault(x => x.Cedula == id);
            if (clientes == null)
            {
                return NotFound();
            }
            return Ok(clientes);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Clientes clientes)
        {
            if (ModelState.IsValid) 
            {
                context.Clientes.Add(clientes);
                context.SaveChanges();

                return Ok(clientes);
              //  return new CreatedAtRouteResult("cliente Creada",
              //  new { id = clientes.Cedula }, clientes);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Clientes clientes, string id)
        {
            if (clientes.Cedula != id)
            {
                return BadRequest();
            }
            context.Entry(clientes).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var clientes = context.Clientes.FirstOrDefault(x => x.Cedula == id);
            if (clientes == null)
            {
                return NotFound();
            }
            context.Clientes.Remove(clientes);
            context.SaveChanges();
            return Ok(clientes);
        }
    }
}



