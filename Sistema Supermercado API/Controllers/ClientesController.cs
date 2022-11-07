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
    public class ClientesController : ControllerBase
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
            var cliente = context.Clientes.FirstOrDefault(x => x.Cedula == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return new CreatedAtRouteResult("cliente Creada",
                new { id = cliente.Cedula }, cliente);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Clientes cliente, string id)
        {
            if (cliente.Cedula != id)
            {
                return BadRequest();
            }
            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.Cedula == id);
            if (cliente == null)
            {
                return NotFound();
            }
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return Ok(cliente);
        }
    }
}



