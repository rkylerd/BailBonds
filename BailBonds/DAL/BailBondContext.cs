using BailBonds.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BailBonds.DAL
{
    public class BailBondContext : DbContext
    {

        public BailBondContext()
             : base("BailBondContext")
        {

        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<AgentCounty> AgentCounties { get; set; }
        public DbSet<ClientAgentReview> ClientAgentReviews { get; set; }

    }
}