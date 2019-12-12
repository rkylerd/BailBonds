using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewID { get; set; }

        [Display(Name = "Review")]
        [Required(ErrorMessage = "Enter your personalized, dramatized review before submitting.")]
        [StringLengthAttribute(300, ErrorMessage = "Your review must be shorter than 300 characters.")]
        public string ReviewText { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter your name.")]
        [StringLengthAttribute(20, ErrorMessage = "Your name must be shorter than 20 characters.")]
        public string ClientID { get; set; }

        public string Date { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Just rate your service, ma'am. Thank you.")]
        [Range(1, 5, ErrorMessage = "Rate your experience with us 1 to 5.")]
        public int Rating { get; set; }

        public Review()
        {

        }

        public Review(int identifier, string reviewBody, string author, string date, int rating)
        {
            this.ReviewID = identifier;
            this.ReviewText = reviewBody;
            this.ClientID = author;
            this.Date = date;
            this.Rating = rating;
        }
    }
}