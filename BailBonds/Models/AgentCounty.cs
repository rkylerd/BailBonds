using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    [Table("AgentCounty")]
    public class AgentCounty
    {
        [Key, Column(Order = 0)]
        public int CountyID { get; set; }

        [Key, Column(Order = 1)]
        public int AgentID { get; set; }
        
    }
}