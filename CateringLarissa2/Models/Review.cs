using System.ComponentModel.DataAnnotations;

namespace CateringLarissa2.Models
{
    public class Review
    {
        public int id { get; set; }
        
        [Required]

        public string title { get; set; }
        public string? description { get; set; }
        public string user { get; set; }

        [Range(1, 5)]
        [Required]
        public int rating { get; set; }

        public DateTime CreatedDate { get; set; }
        public Review()
        {
            
                this.CreatedDate = DateTime.Now;
              
            
        }
    }
}
