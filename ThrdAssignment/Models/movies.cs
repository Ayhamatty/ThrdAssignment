using System.ComponentModel.DataAnnotations;

namespace ThrdAssignment.Models
{
    public class movies
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }

        [Display(Name = "Release Year")]
        public int ReleasYear { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        
    }
}
