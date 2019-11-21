using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    public class Review
    {
        public string identifier { get; set; }

        [Display(Name = "Review")]
        [Required(ErrorMessage = "Enter your personalized, dramatized review before submitting.")]
        [StringLengthAttribute(300, ErrorMessage = "Your review must be shorter than 300 characters.")]
        public string reviewBody { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter your name.")]
        [StringLengthAttribute(20, ErrorMessage = "Your name must be shorter than 20 characters.")]
        public string author { get; set; }

        public string date { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Just rate your service, ma'am. Thank you.")]
        [Range(1, 5, ErrorMessage = "Rate your experience with us 1 to 5.")]
        public int rating { get; set; }

        public Review()
        {

        }

        public Review(string identifier, string reviewBody, string author, string date, int rating)
        {
            this.identifier = identifier;
            this.reviewBody = reviewBody;
            this.author = author;
            this.date = date;
            this.rating = rating;
        }
    }
}