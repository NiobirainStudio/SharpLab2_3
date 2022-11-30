using System.ComponentModel.DataAnnotations;

namespace SharpLab2_3.DbData
{
    public class Artists
    {
        [Key]
        public int ArtistId { get; set; }
        [Required]
        public string ArtistName { get; set; }
    }
}
