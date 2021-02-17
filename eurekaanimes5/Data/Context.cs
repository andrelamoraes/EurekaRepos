using eurekaanimes5.Models;
using Microsoft.EntityFrameworkCore;

namespace eurekaanimes5.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Animes> Animes { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Noticias> News { get; set; }
        public DbSet<Personagens> Characters { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Usuarios> Users { get; set; }
        public DbSet<AnimesTags> AnimesTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AnimesTags>().HasKey(x => new
            {
                x.AnimeID,
                x.TagsTagID
            });
        }
    }


}
