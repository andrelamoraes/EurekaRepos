using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEureka.Data;

namespace ProjetoEureka.Controllers
{
    
    public class NoticiaController : Controller
    {
        private readonly Context _context;
        public NoticiaController(Context context)
        {
            _context = context;
        }
        [HttpGet,Route("Noticia/{id}-{titulo}")]
        public IActionResult Index(int id, string titulo)
        {
            var noticia = _context.euk_noticia.First(x => x.Id == id);
            return View(noticia);
        }

    }
}
