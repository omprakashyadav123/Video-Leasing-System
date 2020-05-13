using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Addmovie> Addmovie { get; set; }
        public DbSet<RazorPagesMovie.Models.Adduser> Adduser { get; set; }
         public DbSet<RazorPagesMovie.Models.Record> Record {get;set;}

      
    }
}