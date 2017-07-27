using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models
{
    public class Review
    {        
        public int ReviewID { get; set; }

        // The Display here is not working, neither in the course 
        [Display(Name = "Album")]
        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string ReviewerEmail { get; set; }
    }
}