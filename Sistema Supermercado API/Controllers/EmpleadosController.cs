
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
    public class EmpleadosController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public EmpleadosController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Empleados> Get()
        {
            return context.Empleados.ToList();
        }
        [HttpGet("{string}", Name = "empleado Creada")]
        public IActionResult GetById(string id)
        {
            var empleado = context.Empleados.FirstOrDefault(x => x.Codigo == id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Empleados empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return new CreatedAtRouteResult("empleado Creada",
                new { id = empleado.Codigo }, empleado);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Empleados empleado, string id)
        {
            if (empleado.Codigo != id)
            {
                return BadRequest();
            }
            context.Entry(empleado).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var empleado = context.Empleados.FirstOrDefault(x => x.Codigo == id);
            if (empleado == null)
            {
                return NotFound();
            }
            context.Empleados.Remove(empleado);
            context.SaveChanges();
            return Ok(empleado);
        }
    }
}

