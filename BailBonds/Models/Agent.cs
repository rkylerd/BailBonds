using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    public class Agent
    {   [ScaffoldColumn(false)]
        public string agentCode { get; set; }
        public string phoneNum { get; set; }
        public string[] countiesCovered { get; set; }
        public string imageSource { get; set; }
    }
}