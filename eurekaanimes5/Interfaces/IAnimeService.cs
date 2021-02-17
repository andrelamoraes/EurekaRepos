using System.Collections.Generic;
using eurekaanimes5.Models;

namespace eurekaanimes5.Interfaces
{
    public interface IAnimeService
    {
        bool cadastrar(Animes anime);

        List<Animes> listaranimes();

        List<Animes> listarpeloid(int AnimeID);

        List<Animes> listarcategoria(int CategoriaId);

        void Deletar(int AnimeID);


    }
}