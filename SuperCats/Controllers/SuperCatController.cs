using SuperCats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperCats.Controllers
{
    public class SuperCatController : Controller
    {
        ApplicationDbContext context;

        public SuperCatController()
        {
            context = new ApplicationDbContext();
        }
 

        // GET: SuperCat
        public ActionResult Index()
        {
            var listOfSuperCats = context.SuperCats.ToList();
            return View(listOfSuperCats);
        }

        // GET: SuperCat/Details/5
        public ActionResult Details(int id)
        {
            var superCat = context.SuperCats.Find(id);
            return View(superCat);
        }

        // GET: SuperCat/Create
        public ActionResult Create()
        {
            SuperCat superCat = new SuperCat();
            return View(superCat);
        }

        // POST: SuperCat/Create
        [HttpPost]
        public ActionResult Create(SuperCat superCat)
        {
            try
            {
                context.SuperCats.Add(superCat);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperCat/Edit/5
        public ActionResult Edit(int id)
        {
            SuperCat superCat = context.SuperCats.Find(id);
            return View(superCat);
        }

        // POST: SuperCat/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperCat superCat)
        {
            try
            {
                SuperCat catFromDb = context.SuperCats.Find(id);
                catFromDb.Name = superCat.Name;
                catFromDb.Temperment = superCat.Temperment;
                catFromDb.CoatColor = superCat.CoatColor;
                catFromDb.Sound = superCat.Sound;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperCat/Delete/5
        public ActionResult Delete(int id)
        {
            SuperCat superCat = context.SuperCats.Find(id);
            return View(superCat);
        }

        // POST: SuperCat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperCat superCat)
        {
            try
            {
                SuperCat catFromDb = context.SuperCats.Find(id);
                context.SuperCats.Remove(catFromDb);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
