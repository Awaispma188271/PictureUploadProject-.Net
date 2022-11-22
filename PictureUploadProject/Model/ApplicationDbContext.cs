using Microsoft.EntityFrameworkCore;

namespace PictureUploadProject.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<image> ImagesPath { get; set; }
        
    }
}

