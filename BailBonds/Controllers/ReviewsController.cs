using BailBonds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BailBonds.Controllers
{
    public class ReviewsController : Controller
    {
        public static List<Review> reviewsList = new List<Review>()
        {
            new Review("1", "Best company I have ever worked with!", "Robin Banks", DateTime.Now.ToString(), 5),
            new Review("2","My husband was out of jail in 2 hours", "Robin Whood", DateTime.Now.ToString(), 5),
            new Review("3","They found me even hiding under my grandma's bed", "Joe Woo", DateTime.Now.ToString(), 5)
        };

        // GET: Reviews
        public ActionResult Index()
        {
            ViewBag.reviews = reviewsList;
            return View();
        }


        [HttpPost]
        public ActionResult Create(Review review)
        {
            review.date = DateTime.Now.ToString();
            review.identifier = (reviewsList.Count + 1) + "";

            if (ModelState.IsValid)
            {
                reviewsList.Add(review);
                
            }

            ViewBag.Message = "Check out 'dem reviews";
            ViewBag.reviews = reviewsList;
            return View("~/Views/Reviews/Index.cshtml");
        }
    }
}