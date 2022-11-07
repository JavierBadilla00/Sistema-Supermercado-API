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
    public class CategoriaProductoController : ControllerBase
    {
        private readonly SUPERMERCADO_LATINOContext context;
        public CategoriaProductoController(SUPERMERCADO_LATINOContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<CategoriaProducto> Get()
        {
            return context.CategoriaProducto.ToList();
        }
        [HttpGet("{string}", Name = "categoriaproductos Creada")]
        public IActionResult GetById(string id)
        {
            var categoriaproductos = context.CategoriaProducto.FirstOrDefault(x => x.Id == id);
            if (categoriaproductos == null)
            {
                return NotFound();
            }
            return Ok(categoriaproductos);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CategoriaProducto categoriaproductos)
        {
            if (ModelState.IsValid)
            {
                context.CategoriaProducto.Add(categoriaproductos);
                context.SaveChanges();
                return new CreatedAtRouteResult("categoriaproductos Creada",
                new { id = categoriaproductos.Id }, categoriaproductos);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CategoriaProducto categoriaproductos, string id)
        {
            if (categoriaproductos.Id != id)
            {
                return BadRequest();
            }
            context.Entry(categoriaproductos).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var categoriaproductos = context.CategoriaProducto.FirstOrDefault(x => x.Id == id);
            if (categoriaproductos == null)
            {
                return NotFound();
            }
            context.CategoriaProducto.Remove(categoriaproductos);
            context.SaveChanges();
            return Ok(categoriaproductos);
        }
    }
}


