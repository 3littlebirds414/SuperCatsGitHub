using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperCats.Models;

namespace SuperCats.Controllers
{
    public class SuperDogController : Controller
    {
        ApplicationDbContext context;
        public SuperDogController()
        {
            context = new ApplicationDbContext();
        }

        //Get: SuperDog
        public ActionResult Index()
        {
            var listOfSuperDogs = context.SuperDogs.ToList();
            return View(listOfSuperDogs);
        }

        //Get: SuperDog/Details
        public ActionResult Details(int id)
        {
            var superDog = context.SuperDogs.Find(id);
            return View(superDog);
        }

        //Get: SuperDog/Create
        public ActionResult Create()
        {
            SuperDog superDog = new SuperDog();
            return View(superDog);
        }

        //Post: SuperDog/Create
        [HttpPost]
        public ActionResult Create(SuperDog superDog)
        {
            try
            {
                context.SuperDogs.Add(superDog);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Get: SuperDog/Edit
        public ActionResult Edit(int id)
        {
            SuperDog superDog = context.SuperDogs.Find(id);
            return View(superDog);
        }
        //Post: SuperDog/Edit
        [HttpPost]
        public ActionResult Edit(int id, SuperDog superDog)
        {
            try
            {
                SuperDog superDogFromDb = context.SuperDogs.Find(id);
                superDogFromDb.Sound = superDog.Sound;
                superDogFromDb.TagNumber = superDog.TagNumber;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Get: SuperDog/Delete
        public ActionResult Delete(int id)
        {
            SuperDog superDogFromDb = context.SuperDogs.Find(id);
            return View(superDogFromDb);
        }
        //Post: SuperDog/Delete
        public ActionResult Delete (int id, SuperDog superDog)
        {
            try
            {
                SuperDog superDogFromDb = context.SuperDogs.Find(id);
                context.SuperDogs.Remove(superDogFromDb);
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