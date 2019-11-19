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
        //Gui changed this lol jjj
        string Gui = "Gui is awesomejhfjg";

        public static List<Agent> agentList = new List<Agent>();
        
        public ActionResult Index()
        {
            return View(agentList);
        }

        public ActionResult Create(Agent agent)
        {
            agent.agentCode = "" + agentList.Count + 1;
            if (ModelState.IsValid)
            {
                agentList.Add(agent);
                return View("Index");
            }

            return View();
        }

        public ActionResult Agents()
        {
            return View(agentList);
        }

        [HttpGet]
        public ActionResult Edit(String agentCode)
        {
            Agent editAgent = agentList.FirstOrDefault(x => x.agentCode == agentCode);
            return View(editAgent);
        }

        [HttpPost]
        public ActionResult Edit(Agent editedAgent)
        {
            if (ModelState.IsValid)
            {
                for (int agentCount = 0; agentCount < agentList.Count; agentCount++)
                {
                    if (agentList[agentCount].agentCode == editedAgent.agentCode)
                    {
                        agentList[agentCount] = editedAgent;
                        break;
                    }
            
                }
                return View("Index");
            }
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}