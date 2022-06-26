using Microsoft.EntityFrameworkCore;
using Resto_Backend.Models;

namespace Resto_Backend.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<PageIntro> pageIntros { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Icon> icons { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<AboutImg> aboutImgs { get; set; }
        public DbSet<Specialties> specialties { get; set; }
        public DbSet<Team> teams { get; set; }
    }
}
