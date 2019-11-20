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
        public string fName { get; set; }
        public string lName { get; set; }
        public string phoneNum { get; set; }
        public List<string> countiesCovered { get; set; }
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