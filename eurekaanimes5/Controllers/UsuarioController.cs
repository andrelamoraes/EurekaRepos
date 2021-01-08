using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("usuarios")]
    public class UsuarioController : Controller
    {

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuarios>> Post(
                    [FromServices] Context context,
                    [FromBody] Usuarios usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {

                context.Users.Add(usuario);
                await context.SaveChangesAsync();

                usuario.UserPassword = "";

                return Ok(usuario);
            }
            catch
            {
                return BadRequest(new { message = "Erro." });
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromServices] Context context,
        [FromBody] Usuarios usuario)
        {

            var user = await context.Users
            .AsNoTracking()
            .Where(x => x.UserName == usuario.UserName && x.UserPassword == usuario.UserPassword)
            .FirstOrDefaultAsync();

            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            //var token = TokenService.GenerateToken(user);

            usuario.UserPassword = "";
            /*return new
            {
                user = user,
                token = token
            };*/
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuarios>> Put(
         [FromServices] Context context,
         int id,
         [FromBody] Usuarios usuario
        )
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (id != usuario.UserID)
                return NotFound(new { message = "Usuário não encontrado" });

            try
            {
                context.Entry(usuario).State = EntityState.Modified;
                await context.SaveChangesAsync();
                usuario.UserPassword = "";
                return Ok(usuario);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Usuarios>>> Delete(
        int id,
        [FromServices] Context context)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserID == id);
            if (user == null)
                return NotFound(new { message = "Usuário não encontrado." });
            try
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover o usuário." });
            }

            return Ok();
        }
    }
}