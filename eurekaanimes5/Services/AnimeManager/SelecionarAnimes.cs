using eurekaanimes5.Data;
using eurekaanimes5.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eurekaanimes5.Services.AnimeManager
{
    public class SelecionarAnimes
    {
        private Context _context;

        public SelecionarAnimes(Context context)
        {
            _context = context;
        }

        List<Animes> listaranimes()
        {
            var animes = (from a in _context.Animes
                          join at in _context.AnimesTags on a.AnimeID equals at.AnimeID
                          join tag in _context.Tags on at.TagsTagID equals tag.TagID
                          select new Animes
                          {
                              AnimeID = a.AnimeID,
                              Name = a.Name,
                              Year = a.Year,
                              English = a.English,
                              Romanji = a.Romanji,
                              Japanese = a.Japanese,
                              Type = a.Type,
                              Episodes = a.Episodes,
                              Status = a.Status,
                              Aired = a.Aired,
                              Season = a.Season,
                              Classification = a.Classification,
                              Producers = a.Producers,
                              Studio = a.Studio,
                              Duration = a.Duration,
                              Sinopse = a.Sinopse,
                              CategoryID = a.CategoryID,
                              Tags = a.Tags,
                              Category = a.Category
                          }).ToList();

            return animes.GroupBy(x => x.AnimeID).Select(x => x.FirstOrDefault()).ToList();

        }

        List<Animes> listarbyid(int AnimeID)
        {
            var animes = (from a in _context.Animes
                          join at in _context.AnimesTags on a.AnimeID equals at.AnimeID
                          join tag in _context.Tags on at.TagsTagID equals tag.TagID
                          where a.AnimeID == AnimeID
                          select new Animes
                          {
                              AnimeID = a.AnimeID,
                              Name = a.Name,
                              Year = a.Year,
                              English = a.English,
                              Romanji = a.Romanji,
                              Japanese = a.Japanese,
                              Type = a.Type,
                              Episodes = a.Episodes,
                              Status = a.Status,
                              Aired = a.Aired,
                              Season = a.Season,
                              Classification = a.Classification,
                              Producers = a.Producers,
                              Studio = a.Studio,
                              Duration = a.Duration,
                              Sinopse = a.Sinopse,
                              CategoryID = a.CategoryID,
                              Tags = a.Tags,
                              Category = a.Category
                          }).ToList();

            return animes.GroupBy(x => x.AnimeID).Select(x => x.FirstOrDefault()).ToList();
        }

        List<Animes> listarbycategoria(int Categoriaid)
        {
            var animes = (from a in _context.Animes
                          join at in _context.AnimesTags on a.AnimeID equals at.AnimeID
                          join tag in _context.Tags on at.TagsTagID equals tag.TagID
                          where a.CategoryID == Categoriaid
                          select new Animes
                          {
                              AnimeID = a.AnimeID,
                              Name = a.Name,
                              Year = a.Year,
                              English = a.English,
                              Romanji = a.Romanji,
                              Japanese = a.Japanese,
                              Type = a.Type,
                              Episodes = a.Episodes,
                              Status = a.Status,
                              Aired = a.Aired,
                              Season = a.Season,
                              Classification = a.Classification,
                              Producers = a.Producers,
                              Studio = a.Studio,
                              Duration = a.Duration,
                              Sinopse = a.Sinopse,
                              CategoryID = a.CategoryID,
                              Tags = a.Tags,
                              Category = a.Category
                          }).ToList();

            return animes.GroupBy(x => x.AnimeID).Select(x => x.FirstOrDefault()).ToList();
        }

        public List<Animes> listartodos()
        {
            return this.listaranimes();
        }

        public List<Animes> listarporid(int AnimeID)
        {
            return this.listarbyid(AnimeID);
        }

        public List<Animes> listarporcategoria(int categoriaid)
        {
            return this.listarbycategoria(categoriaid);
        }
    }
}