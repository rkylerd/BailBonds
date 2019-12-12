using BailBonds.DAL;
using BailBonds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BailBonds.Controllers
{
    public class AgentsController : Controller
    {

        private BailBondContext db = new BailBondContext();

        public ActionResult Index()
        {
            //agentList.Add();
            
            return View(db.Agents.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Agent agent)
        {

            //agent.countiesCovered = new List<string>() { "Salt Lake" };
            if (ModelState.IsValid)
            {
                db.Agents.Add(agent);
                return View("Index", db.Agents.ToList());
            }

            return View();
        }

        public ActionResult Agents()
        {
            return View(db.Agents.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int? agentCode)
        {
            
            Agent editAgent = db.Agents.ToList().FirstOrDefault(x => x.AgentID == agentCode);
            return View(editAgent);
        }

        [HttpPost]
        public ActionResult Edit(Agent editedAgent)
        {
            if (ModelState.IsValid)
            {
                for (int agentCount = 0; agentCount < db.Agents.ToList().Count; agentCount++)
                {
                    if (db.Agents.ToList()[agentCount].AgentID == editedAgent.AgentID)
                    {
                        db.Agents.ToList()[agentCount] = editedAgent;
                        break;
                    }
            
                }
                return View("Index", db.Agents.ToList());
            }
            return View();
        }

        public ActionResult Details(int? agentCode)
        {
            Agent editAgent = db.Agents.ToList().FirstOrDefault(x => x.AgentID == agentCode);
            return View(editAgent);
        }

        [HttpGet]
        public ActionResult Delete(int? agentCode)
        {
            for (int agentCounter = 0; agentCounter < db.Agents.ToList().Count; agentCounter++)
            {
                if (db.Agents.ToList()[agentCounter].AgentID == agentCode)
                {
                    db.Agents.ToList().RemoveAt(agentCounter);
                }
            }

            return View("Index", db.Agents.ToList());
        }
    }
}