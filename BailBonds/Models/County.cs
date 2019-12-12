using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    [Table("Counties")]
    public class County
    {
        [Key]
        public string CountyID { get; set; }
        public string Name { get; set; }
    }
}