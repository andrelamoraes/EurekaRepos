using System.Collections.Generic;
using eurekaanimes5.Data;
using eurekaanimes5.Interfaces;
using eurekaanimes5.Models;
using eurekaanimes5.Services.AnimeManager;

namespace eurekaanimes5.Services
{
    public class AnimeService : IAnimeService
    {
        private Context _context;

        public AnimeService(Context context)
        {
            _context = context;
        }
        public bool cadastrar(Animes anime)
        {
            var cadastrarAnime = new CadastrarAnime(_context);
            cadastrarAnime.cadastrar(anime);
            return true;
        }

        public List<Animes> listaranimes()
        {
            var selecionarAnimes = new SelecionarAnimes(_context);

            return selecionarAnimes.listartodos();
        }


        public void Deletar(int AnimeID)
        {
            var deletaranime = new DeletarAnime(_context);

            deletaranime.apagar(AnimeID);
        }

        public List<Animes> listarpeloid(int AnimeID)
        {
            var selecionarAnimes = new SelecionarAnimes(_context);

            return selecionarAnimes.listarporid(AnimeID);
        }

        public List<Animes> listarcategoria(int CategoriaId)
        {
            var selecionarAnimes = new SelecionarAnimes(_context);

            return selecionarAnimes.listarporcategoria(CategoriaId);
        }
    }
}