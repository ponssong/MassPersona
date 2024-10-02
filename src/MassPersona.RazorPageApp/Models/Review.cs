using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MassPersona.RazorPageApp.Models
{
    [Table("Reviews")]
    public class Review
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ReviewID")]
        public int ReviewID { get; set; }
        [Column("Title")]
        public string Title { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        [Column("ReviewText")]
        public string ReviewText { get; set; }
        [Column("Rating")]
        public int Rating { get; set; }
        [Column("DateReviewed")]
        public DateTime DateReviewed { get; set; }
        
    }
}
