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

        public static List<Agent> agentList = new List<Agent>()
        {
            new Agent("1", "Terry", "Berry", "804564568", new List<string>(new string[] { "Juab", "Sanpete" }),
                 "https://members.cogwa.org/uploads/do-you-have-to-be-a-tough-guy-to-be-a-man.jpg"),
            new Agent("2", "Gene", "Eee", "8045678975", new List<string>(new string[] { "Utah"}),
                 "https://cdn.quotesgram.com/img/61/31/1273965187-792251-tough-guys.jpg"),
            new Agent("3", "Gene", "Eee", "8045678975", new List<string>(new string[] { "Utah"}),
                 "https://correspondent.afp.com/sites/default/files/styles/adaptative/adaptive-image/public/medias/aa_new_posts/countries/britain/uk-sport/tough-guy-feb2017/britain-lifestyle-toughguy111.jpg?itok=S16pZcC2"),
            new Agent("4", "Ulysses", "Martinez", "8016600975", new List<string>(new string[] { "Garfield", "Duchesne"}),
                 "http://4.bp.blogspot.com/---bZjdDhZTk/Tx7Se_mV_JI/AAAAAAAAA2g/LmxVU1poCZE/s1600/tough-guy-motivational.jpg")
        };
       
        
        public ActionResult Index()
        {
            //agentList.Add();
            
            return View(agentList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Agent agent)
        {
            agent.agentCode = "" + agentList.Count + 1;
            agent.countiesCovered = new List<string>() { "Salt Lake" };
            if (ModelState.IsValid)
            {
                agentList.Add(agent);
                return View("Index", agentList);
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
                return View("Index", agentList);
            }
            return View();
        }

        public ActionResult Details(string agentCode)
        {
            Agent editAgent = agentList.FirstOrDefault(x => x.agentCode == agentCode);
            return View(editAgent);
        }

        [HttpGet]
        public ActionResult Delete(String agentCode)
        {
            for (int agentCounter = 0; agentCounter < agentList.Count; agentCounter++)
            {
                if (agentList[agentCounter].agentCode == agentCode)
                {
                    agentList.RemoveAt(agentCounter);
                }
            }

            return View("Index", agentList);
        }
    }
}