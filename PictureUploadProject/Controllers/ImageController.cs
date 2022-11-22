using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PictureUploadProject.Model;

namespace PictureUploadProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly ApplicationDbContext _context;
        public ImageController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("ImageUpload")]
        public async Task<IActionResult> ImageUpload(image obj)
        {
            try
            {
                var db = new image()
                {
                    ImagePath = obj.ImagePath,
                    Title = obj.Title,
                };
                await _context.ImagesPath.AddAsync(db);
                await _context.SaveChangesAsync();  
                return Ok(db);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }

 
}
