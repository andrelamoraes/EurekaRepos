using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEureka.Controllers
{
    
    public class NoticiaController : Controller
    {
       [HttpGet,Route("Noticia/{id}-{titulo}")]
        public IActionResult Index(int id, string titulo)
        {
            return View();
        }

    }
}
