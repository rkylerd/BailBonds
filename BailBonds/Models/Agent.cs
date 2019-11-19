using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BailBonds.Models
{
    public class Agent
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private List<string> list;
        private string v5;

        [ScaffoldColumn(false)]
        public string agentCode { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phoneNum { get; set; }
        public string[] countiesCovered { get; set; }
        public string imageSource { get; set; }

        public Agent()
        {
            
        }

        public Agent(string agentCode, string fName, string lName, string phoneNum, string[] countiesCovered, string imageSource)
        {
            this.agentCode = agentCode;
            this.fName = fName;
            this.lName = lName;
            this.phoneNum = phoneNum;
            this.countiesCovered = countiesCovered;
            this.imageSource = imageSource;
        }

        public Agent(string v1, string v2, string v3, string v4, List<string> list, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.list = list;
            this.v5 = v5;
        }
    }
}