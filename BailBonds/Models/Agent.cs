using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    [Table("Agents")]
    public class Agent
    {

        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter a valid first name.")]
        [StringLengthAttribute(20, ErrorMessage = "First name must be shorter than 20 characters.")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter a valid last name.")]
        [StringLengthAttribute(20, ErrorMessage = "Last name must be shorter than 20 characters.")]
        public string LName { get; set; }

        [Display(Name = "Phone #")]
        [Required(ErrorMessage = "Enter a valid last name.")]
        [StringLengthAttribute(10, ErrorMessage = "Last name must be shorter than 20 characters.")]
        public string PhoneNum { get; set; }


    [Required(ErrorMessage = "Enter a valid url image.")]
        
        public string ImageSource { get; set; }

        public Agent()
        {
            
        }

        public Agent(string fName, string lName, string phoneNum, string imageSource)
        {
            this.FName = fName;
            this.LName = lName;
            this.PhoneNum = phoneNum;
            this.ImageSource = imageSource;
        }

    }
}