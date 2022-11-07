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
    public class CuentasController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public CuentasController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Cuentas> Get()
        {
            return context.Cuentas.ToList();
        }
        [HttpGet("{string}", Name = "cuenta Creada")]
        public IActionResult GetById(string id)
        {
            var cuenta = context.Cuentas.FirstOrDefault(x => x.Id == id);
            if (cuenta == null)
            {
                return NotFound();
            }
            return Ok(cuenta);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Cuentas cuenta)
        {
            if (ModelState.IsValid)
            {
                context.Cuentas.Add(cuenta);
                context.SaveChanges();
                return new CreatedAtRouteResult("cuenta Creada",
                new { id = cuenta.Id }, cuenta);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Cuentas cuenta, string id)
        {
            if (cuenta.Id != id)
            {
                return BadRequest();
            }
            context.Entry(cuenta).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var cuenta = context.Cuentas.FirstOrDefault(x => x.Id == id);
            if (cuenta == null)
            {
                return NotFound();
            }
            context.Cuentas.Remove(cuenta);
            context.SaveChanges();
            return Ok(cuenta);
        }
    }
}


