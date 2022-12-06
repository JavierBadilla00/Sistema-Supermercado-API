using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Supermercado_API.Entities;

namespace Sistema_Supermercado_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly SupermercadoBDContext context;
        public CategoriasController(SupermercadoBDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Categorias> Get()
        {
            return context.Categorias.ToList();
        }
        [HttpGet("{id}", Name = "Categoriass Creada")]
        public IActionResult GetById(int id)
        {
            var Categoriass = context.Categorias.FirstOrDefault(x => x.Id == id);
            if (Categoriass == null)
            {
                return NotFound();
            }
            return Ok(Categoriass);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Categorias Categoriass)
        {
            if (ModelState.IsValid)
            {
                context.Categorias.Add(Categoriass);
                context.SaveChanges();
                return new CreatedAtRouteResult("Categoriass Creada",
                new { id = Categoriass.Id }, Categoriass);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Categorias Categoriass, int id)
        {
            if (Categoriass.Id != id)
            {
                return BadRequest();
            }
            context.Entry(Categoriass).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Categoriass = context.Categorias.FirstOrDefault(x => x.Id == id);
            if (Categoriass == null)
            {
                return NotFound();
            }
            context.Categorias.Remove(Categoriass);
            context.SaveChanges();
            return Ok(Categoriass);
        }
    }
}


