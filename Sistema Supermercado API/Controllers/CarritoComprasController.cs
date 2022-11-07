using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Supermercado_API.Entity;

namespace WebApiHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoComprasController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public CarritoComprasController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<CarritoCompras> Get()
        {
            return context.CarritoCompras.ToList();
        }
        [HttpGet("{string}", Name = "carritocompra Creada")]
        public IActionResult GetById(string id)
        {
            var carritocompra = context.CarritoCompras.FirstOrDefault(x => x.Id == id);
            if (carritocompra == null)
            {
                return NotFound();
            }
            return Ok(carritocompra);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CarritoCompras carritocompra)
        {
            if (ModelState.IsValid)
            {
                context.CarritoCompras.Add(carritocompra);
                context.SaveChanges();
                return new CreatedAtRouteResult("carritocompra Creada",
                new { id = carritocompra.Id }, carritocompra);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CarritoCompras carritocompra, string id)
        {
            if (carritocompra.Id != id)
            {
                return BadRequest();
            }
            context.Entry(carritocompra).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var carritocompra = context.CarritoCompras.FirstOrDefault(x => x.Id == id);
            if (carritocompra == null)
            {
                return NotFound();
            }
            context.CarritoCompras.Remove(carritocompra);
            context.SaveChanges();
            return Ok(carritocompra);
        }
    }
}

