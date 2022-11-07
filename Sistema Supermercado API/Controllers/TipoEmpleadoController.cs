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
    public class TipoEmpleadoController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public TipoEmpleadoController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<TipoEmpleado> Get()
        {
            return context.TipoEmpleado.ToList();
        }
        [HttpGet("{string}", Name = "tipoempleado Creada")]
        public IActionResult GetById(string id)
        {
            var tipoempleado = context.TipoEmpleado.FirstOrDefault(x => x.Id == id);
            if (tipoempleado == null)
            {
                return NotFound();
            }
            return Ok(tipoempleado);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TipoEmpleado tipoempleado)
        {
            if (ModelState.IsValid)
            {
                context.TipoEmpleado.Add(tipoempleado);
                context.SaveChanges();
                return new CreatedAtRouteResult("tipoempleado Creada",
                new { id = tipoempleado.Id }, tipoempleado);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TipoEmpleado tipoempleado, string id)
        {
            if (tipoempleado.Id != id)
            {
                return BadRequest();
            }
            context.Entry(tipoempleado).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var tipoempleado = context.TipoEmpleado.FirstOrDefault(x => x.Id == id);
            if (tipoempleado == null)
            {
                return NotFound();
            }
            context.TipoEmpleado.Remove(tipoempleado);
            context.SaveChanges();
            return Ok(tipoempleado);
        }
    }
}
