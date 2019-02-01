using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: SuperHero
        public ActionResult Index()
        {
            return View(db.SuperHeroes);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {

            return View(db.SuperHeroes.Find(id));
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
                
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHeroes superHeroes)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.SuperHeroes.Add(superHeroes);
                    db.SaveChanges();
                   
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(db.SuperHeroes.Find(id));
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHeroes superHeroes)
        {
            try
            {
                // TODO: Add update logic here
                var temp = db.SuperHeroes.Find(id);
                temp.AlterEgoName = superHeroes.AlterEgoName;
                temp.HeroName = superHeroes.HeroName;
                temp.Catchphrase = superHeroes.Catchphrase;
                temp.MainAbility = superHeroes.MainAbility;
                temp.SecondaryAbility = superHeroes.SecondaryAbility;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
          
            return View(db.SuperHeroes.Find(id));
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHeroes superHeroes)
        {
            try
            {
                // TODO: Add delete logic here
                     superHeroes = db.SuperHeroes.Find(id);

                    db.SuperHeroes.Remove(superHeroes);
                    db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
