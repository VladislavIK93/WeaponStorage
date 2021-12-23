using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab11_MYSELF.Models;

namespace Lab11_MYSELF.Controllers
{
    public class HomeController : Controller
    {
        Lab11_MyselfDB db = new Lab11_MyselfDB();

        [HttpGet]
        public ActionResult Index()
        {
            var weapons = (from weapon in db.Weapon
                         join weamag in db.WeaponMagazine on weapon.IdWeapon equals weamag.IdWeapon
                         join magazine in db.Magazine on weamag.IdMagazine equals magazine.IdMagazine
                         where magazine.Amount > 16
                         select weapon).ToList();
            return View(weapons);
        }

        [HttpGet]
        public ActionResult Index2()
        {
            var weapons = (from weapon in db.Weapon select weapon).ToList();
            return View(weapons);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var weapons = (from weamag in db.WeaponMagazine where weamag.IdWeapon == id select weamag.Magazine).First();
            return View(weapons);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Weapon weapons = new Weapon();
            return View(weapons);
        }

        [HttpPost]
        public ActionResult Create(Weapon weapons, Magazine magazine)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Weapon.Add(weapons);
                    db.SaveChanges();
                    return RedirectToAction("Index2");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(weapons);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var weaponsEdit = (from weapons in db.Weapon where weapons.IdWeapon == id select weapons).First();
            return View(weaponsEdit);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var weaponsEdit = (from weapons in db.Weapon where weapons.IdWeapon == id select weapons).First();

            try
            {
                UpdateModel(weaponsEdit);
                db.SaveChanges();
                return RedirectToAction("Index2");
            }
            catch
            {
                return View(weaponsEdit);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var weaponsEdit = (from weapons in db.Weapon where weapons.IdWeapon == id select weapons).First();
            return View(weaponsEdit);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var weaponsEdit = (from weapons in db.Weapon where weapons.IdWeapon == id select weapons).First();

            try
            {
                db.Weapon.Remove(weaponsEdit);
                db.SaveChanges();
                return RedirectToAction("Index2");
            }
            catch
            {
                return View(weaponsEdit);
            }
        }
    }
}