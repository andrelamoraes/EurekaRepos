using System.Linq;
using eurekaanimes5.Data;

namespace eurekaanimes5.Services.AnimeManager
{
    public class DeletarAnime
    {
        private Context _context;

        public DeletarAnime(Context context)
        {
            _context = context;
        }

        void deletar(int AnimeID)
        {
            var anime = this._context.Animes.Where(x => x.AnimeID == AnimeID).FirstOrDefault();

            if (anime == null)
                throw new System.Exception("AnimeId errado");

            this._context.Animes.Remove(anime);
        }

        public void apagar(int AnimeID)
        {
            this.deletar(AnimeID);
        }
    }
}