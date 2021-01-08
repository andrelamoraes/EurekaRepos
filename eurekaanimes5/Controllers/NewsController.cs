using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Noticias>>> Get(
             [FromServices] Context context
         )
        {
            var list = await context
            .News
            .Include(x => x.Category)
            .AsNoTracking()
            .ToListAsync();

            return list;
        }


        [HttpPost]
        public async Task<ActionResult<Noticias>> Post(
                    [FromServices] Context context,
                    [FromBody] Noticias news
                )
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = " Não foi possível cadastrar a notícia." });
            try
            {
                context.News.Add(news);
                await context.SaveChangesAsync();
                return Ok(news);
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
            [FromBody] Noticias news,
            int id
        )
        {

            if (!ModelState.IsValid)
                return BadRequest();

            if (id != news.NewsID)
                return NotFound(new { message = "Notícia não encontrada." });

            try
            {
                context.Entry(news).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(news);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Noticias>>> Delete(
        int id,
        [FromServices] Context context)
        {
            var news = await context.News.FirstOrDefaultAsync(x => x.NewsID == id);
            if (news == null)
                return NotFound(new { message = "Notícia não encontrada." });
            try
            {
                context.News.Remove(news);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover a notícia." });
            }

            return Ok();
        }
    }
}