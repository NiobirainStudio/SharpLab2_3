using System.ComponentModel.DataAnnotations;

namespace SharpLab2_3.DbData
{
    public class Albums
    {
        [Key]
        public int AlbumId { get; set; }
        [Required]
        public string AlbumName { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        
        [Required]
        public int ArtistId { get; set; }
        [Required]
        public Artists Artist { get; set; }


        [Required]
        public int GenreId { get; set; }
        [Required]
        public Genres Genre { get; set; }
    }
}
