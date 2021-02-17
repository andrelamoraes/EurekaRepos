using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eurekaanimes5.Data;
using eurekaanimes5.Interfaces;
using eurekaanimes5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Controllers
{
    [Route("animes")]
    public class AnimesController : Controller
    {
        private Context _context;
        private IAnimeService _animeservice;
        public AnimesController(IAnimeService animeservice)
        {
            _animeservice = animeservice;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Animes>>> Get()
        {
            try
            {
                return _animeservice.listaranimes();
            }
            catch (System.Exception e)
            {
                return StatusCode(500, $"Não foi possível listar os animes {e.Message}");
            }

        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Animes>>> GetById(int AnimeID)
        {
            try
            {
                return _animeservice.listarpeloid(AnimeID);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, $"Não foi possível listar os animes {e.Message}");
            }

        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Animes>>> GetByCategory(int CategoriaID)
        {
            try
            {
                return _animeservice.listarcategoria(CategoriaID);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, $"Não foi possível listar os animes {e.Message}");
            }

        }

        [HttpPost("[action]")]
        public async Task<ActionResult<Animes>> Post([FromBody] Animes anime)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Erro ao cadastrar anime;" });

            try
            {
                _animeservice.cadastrar(anime);
                return Ok(anime);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro ao cadastrar o anime");
            }

        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<Animes>> Delete(int AnimeID)
        {
            try
            {
                _animeservice.Deletar(AnimeID);
                return Ok();
            }
            catch (System.Exception e)
            {
                return StatusCode(500, "Erro ao deletar o anime");
            }
        }
    }
}

