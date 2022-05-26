using Gallery2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace Gallery2._0.Database
{
    public class GalleryDbContext:DbContext
    {
        public GalleryDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTags> Tags { get; set; }
    }
}
