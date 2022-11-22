using System.ComponentModel.DataAnnotations;

namespace PictureUploadProject.Model
{
    public class image
    {
        [Key]
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; } 
    }
}
