using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("animes")]
    public class AnimesController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Animes>>> Get([FromServices] Context context)
        {
            var list = await context
            .Animes
            .Include(x => x.Category)
            .AsNoTracking()
            .ToListAsync();

            return list;
        }

        [HttpPost]
        public async Task<ActionResult<Animes>> Post([FromServices] Context context, [FromBody] Animes anime)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Erro ao cadastrar anime;" });

            context.Animes.Add(anime);
            await context.SaveChangesAsync();

            return Ok(anime);
        }
    }
}

