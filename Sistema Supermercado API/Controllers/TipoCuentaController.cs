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
    public class TipoCuentaController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public TipoCuentaController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<TipoCuenta> Get()
        {
            return context.TipoCuenta.ToList();
        }
        [HttpGet("{string}", Name = "tipocuenta Creada")]
        public IActionResult GetById(string id)
        {
            var tipocuenta = context.TipoCuenta.FirstOrDefault(x => x.Id == id);
            if (tipocuenta == null)
            {
                return NotFound();
            }
            return Ok(tipocuenta);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TipoCuenta tipocuenta)
        {
            if (ModelState.IsValid)
            {
                context.TipoCuenta.Add(tipocuenta);
                context.SaveChanges();
                return new CreatedAtRouteResult("tipocuenta Creada",
                new { id = tipocuenta.Id }, tipocuenta);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TipoCuenta tipocuenta, string id)
        {
            if (tipocuenta.Id != id)
            {
                return BadRequest();
            }
            context.Entry(tipocuenta).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var tipocuenta = context.TipoCuenta.FirstOrDefault(x => x.Id == id);

            if (tipocuenta == null)
            {
                return NotFound();
            }
            context.TipoCuenta.Remove(tipocuenta);
            context.SaveChanges();
            return Ok(tipocuenta);
        }
    }
}
