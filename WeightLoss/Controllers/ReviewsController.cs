//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WeightLoss.Models;

//namespace WeightLoss.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: Reviews
//        public ActionResult Index()
//        {
//            var model = from r in _reviews
//                        orderby r.Country
//                        select r;

//            return View(model);
//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
            
//        }

//        static List<RestaurantReview> _reviews = new List<RestaurantReview>
//        {
//            new RestaurantReview {
//                id = 1,
//                Name = "Blus",
//                City = "Łódź",
//                Country = "Poland",
//                rating = 3
//            },
//            new RestaurantReview {
//                id = 2,
//                Name = "Mefisto",
//                City = "Warsaw",
//                Country = "Poland",
//                rating = 2
//            },
//                        new RestaurantReview {
//                id = 3,
//                Name = "Fisty Goat",
//                City = "London",
//                Country = "England",
//                rating = 1
//            }
//        };
//    }
//}
