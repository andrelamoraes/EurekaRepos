using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("characters")]
    public class CharactersController : Controller
    {

        [HttpGet]
        public async Task<ActionResult<List<Personagens>>> Get(
            [FromServices] Context context
        )
        {
            var list = await context
            .Characters
            .Include(x => x.Anime)
            .AsNoTracking()
            .ToListAsync();

            return list;
        }

        [HttpPost]
        public async Task<ActionResult<Personagens>> Post(
            [FromServices] Context context,
            [FromBody] Personagens character
        )
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                context.Characters.Add(character);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest();
            }

            return Ok(character);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Personagens>> Put(
          [FromServices] Context context,
          int id,
          [FromBody] Personagens character
         )
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (id != character.PersonagemID)
                return NotFound(new { message = "Personagem não encontrado." });

            try
            {
                context.Entry(character).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return character;
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Personagens>>> Delete(
        int id,
        [FromServices] Context context)
        {
            var character = await context.Characters.FirstOrDefaultAsync(x => x.PersonagemID == id);
            if (character == null)
                return NotFound(new { message = "Personagem não encontrada." });
            try
            {
                context.Characters.Remove(character);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover o Personagem." });
            }

            return Ok();
        }
    }
}