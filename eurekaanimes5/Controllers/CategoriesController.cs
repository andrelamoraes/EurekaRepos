using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("categories")]
    public class CategoriesController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Categories>>> Get(
            [FromServices] Context context
            )
        {
            var list = await context
            .Categories
            .AsNoTracking()
            .ToListAsync();

            return list;
        }

        [HttpPost]
        public async Task<ActionResult<Categories>> Post(
            [FromServices] Context context,
            [FromBody] Categories category
        )
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { message = "Não foi possível adicionar a categoria." });

                context.Categories.Add(category);
                await context.SaveChangesAsync();

                return Ok(category);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Categories>> Put([FromBody] Categories category,
        [FromServices] Context context,
        int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (id != category.CatID)
                return NotFound(new { message = "Categoria não encontrado" });

            try
            {
                context.Entry(category).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Categories>> Delete(
        [FromServices] Context context,
        int id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.CatID == id);
            if (category == null)
                return NotFound(new { message = "Categoria não encontrada." });
            try
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover a categoria." });
            }

            return Ok();
        }
    }
}