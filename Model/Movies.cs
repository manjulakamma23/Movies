using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? MovieName { get; set; }

        [Required]
        public string? DirectorName { get; set; }

        [Required]
        public int YearOfRelease { get; set; }
    }
}
