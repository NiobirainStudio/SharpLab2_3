using System.ComponentModel.DataAnnotations;

namespace SharpLab2_3.DbData
{
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
    }
}
