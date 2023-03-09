using System.ComponentModel.DataAnnotations;

namespace WebApiTest.Models
{
    public class Recognition
    {
        [Key]
        public int Id { get; set; }
        public string? uuid { get; set; }
        public string? FileName { get; set; }
        public string? UploadTime { get; set; }
        public string? gender { get; set;}
        public int age { get; set; }
        public string? faceencoding { get; set; }
    }
}
