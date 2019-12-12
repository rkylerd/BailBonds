using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    [Table("ReviewUserAgent")]
    public class ClientAgentReview
    {
        [Key, Column(Order = 0)]
        public int ReviewID { get; set; }

        [Key, Column(Order = 1)]
        public int AgentID { get; set; }

        [Key, Column(Order = 2)]
        public int ClientID { get; set; }

    }
}