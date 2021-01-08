using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("tags")]
    public class TagsController : Controller
    {

        [HttpGet]
        public async Task<ActionResult<List<Tags>>> Get(
                   [FromServices] Context context
               )
        {
            var list = await context
            .Tags
            .AsNoTracking()
            .ToListAsync();

            return list;
        }
        [HttpPost]
        public async Task<ActionResult<Tags>> Post(
            [FromServices] Context context,
            [FromBody] Tags tag
        )
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = " Não foi possível cadastrar a Tag." });
            try
            {
                context.Tags.Add(tag);
                await context.SaveChangesAsync();
                return Ok(tag);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Noticias>> Put(
            [FromServices] Context context,
            [FromBody] Tags tag,
            int id
        )
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (id != tag.TagID)
                return NotFound(new { message = "Tag não encontrada." });

            try
            {
                context.Entry(tag).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(tag);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Tags>>> Delete(
        int id,
        [FromServices] Context context)
        {
            var tag = await context.Tags.FirstOrDefaultAsync(x => x.TagID == id);
            if (tag == null)
                return NotFound(new { message = "Tag não encontrada." });
            try
            {
                context.Tags.Remove(tag);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover a Tag." });
            }

            return Ok();
        }
    }
}