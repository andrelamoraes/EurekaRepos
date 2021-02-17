using eurekaanimes5.Data;
using eurekaanimes5.Models;

namespace eurekaanimes5.Services.AnimeManager
{
    public class CadastrarAnime
    {
        private Context _context;

        public CadastrarAnime(Context context)
        {
            _context = context;
        }

        void cadastro(Animes anime)
        {
            var Tags = anime.Tags;

            //acho que é gambiarra
            anime.Tags = null;
            anime.Category = null;

            this._context.Animes.Add(anime);
            this._context.SaveChanges();

            foreach (var item in Tags)
            {
                var animetags = new AnimesTags();

                animetags.AnimeID = anime.AnimeID;
                animetags.TagsTagID = item.TagID;

                this._context.AnimesTags.Add(animetags);
            }

            this._context.SaveChanges();

        }

        public void cadastrar(Animes anime)
        {
            this.cadastro(anime);
        }
    }
}