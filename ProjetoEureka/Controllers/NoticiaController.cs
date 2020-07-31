using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.Extensions.Logging;
using ProjetoEureka.Data;
using ProjetoEureka.Models;
=======
using ProjetoEureka.Data;
>>>>>>> 563f06276b322c371061c98c09bfcc91353360c2

namespace ProjetoEureka.Controllers
{


    public class NoticiaController : Controller
    {
<<<<<<< HEAD
        private ILogger<NoticiaController> _logger;
        private readonly Context _context;

        public NoticiaController(ILogger<NoticiaController> logger, Context context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet, Route("Noticia/{id}-{titulo}")]
=======
        private readonly Context _context;
        public NoticiaController(Context context)
        {
            _context = context;
        }
        [HttpGet,Route("Noticia/{id}-{titulo}")]
>>>>>>> 563f06276b322c371061c98c09bfcc91353360c2
        public IActionResult Index(int id, string titulo)
        {
            var noticia = _context.euk_noticia.First(x => x.Id == id);
            return View(noticia);
        }

        [HttpGet]
        public IActionResult CadastrarNoticia()
        {
            ViewBag.noticias = _context.euk_categoria.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarNoticia(IFormCollection form)
        {
            // Noticia noticia = new Noticia()
            // {
            //     Titulo = form["Titulo"].ToString(),
            //     Id_Categoria = int.Parse(form["selectcategoria"].ToString()),
            //     Descricao = form["Descricao"].ToString(),
            //     Data_criacao = DateTime.Now
            // };
            //_context.euk_noticia.Add(noticia);
            _context.SaveChangesAsync();

            return RedirectToAction("CadastrarNoticia");
        }

    }
}
