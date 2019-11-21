using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    public class Agent
    {

        [ScaffoldColumn(false)]
        public string agentCode { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter a valid first name.")]
        [StringLengthAttribute(20, ErrorMessage = "First name must be shorter than 20 characters.")]
        public string fName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter a valid last name.")]
        [StringLengthAttribute(20, ErrorMessage = "Last name must be shorter than 20 characters.")]
        public string lName { get; set; }

        [Display(Name = "Phone #")]
        [Required(ErrorMessage = "Enter a valid last name.")]
        [StringLengthAttribute(10, ErrorMessage = "Last name must be shorter than 20 characters.")]
        public string phoneNum { get; set; }
        
        public List<string> countiesCovered { get; set; }

        
        [Required(ErrorMessage = "Enter a valid url image.")]
        
        public string imageSource { get; set; }

        public Agent()
        {
            
        }

        public Agent(string agentCode, string fName, string lName, string phoneNum, List<string> countiesCovered, string imageSource)
        {
            this.agentCode = agentCode;
            this.fName = fName;
            this.lName = lName;
            this.phoneNum = phoneNum;
            this.countiesCovered = countiesCovered;
            this.imageSource = imageSource;
        }

    }
}