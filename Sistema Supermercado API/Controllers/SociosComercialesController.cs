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
    public class SociosComercialesController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public SociosComercialesController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<SociosComerciales> Get()
        {
            return context.SociosComerciales.ToList();
        }
        [HttpGet("{string}", Name = "sociocomercial Creada")]
        public IActionResult GetById(string id)
        {
            var sociocomercial = context.SociosComerciales.FirstOrDefault(x => x.CodigoTarjeta == id);
            if (sociocomercial == null)
            {
                return NotFound();
            }
            return Ok(sociocomercial);
        }
        [HttpPost]
        public IActionResult Post([FromBody] SociosComerciales sociocomercial)
        {
            if (ModelState.IsValid)
            {
                context.SociosComerciales.Add(sociocomercial);
                context.SaveChanges();
                return new CreatedAtRouteResult("sociocomercial Creada",
                new { id = sociocomercial.CodigoTarjeta }, sociocomercial);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] SociosComerciales sociocomercial, string id)
        {
            if (sociocomercial.CodigoTarjeta != id)
            {
                return BadRequest();
            }
            context.Entry(sociocomercial).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var sociocomercial = context.SociosComerciales.FirstOrDefault(x => x.CodigoTarjeta == id);
            if (sociocomercial == null)
            {
                return NotFound();
            }
            context.SociosComerciales.Remove(sociocomercial);
            context.SaveChanges();
            return Ok(sociocomercial);
        }
    }
}


