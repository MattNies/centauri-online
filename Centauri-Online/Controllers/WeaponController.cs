using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centauri_Online.Data;
using Centauri_Online.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Centauri_Online.Controllers
{
    public class WeaponController : Controller
    {
        private WeaponData dao = new WeaponData();

        // GET: Weapon
        public ActionResult Index()
        {
            return View(dao.FindAll());
        }

        // GET: Weapon/Details/5
        public ActionResult Details(int id)
        {
            return View(dao.Find(id));
        }

        // GET: Weapon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weapon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]WeaponModel wep)
        {
            try
            {
                dao.Upsert(wep);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Weapon/Edit/5
        public ActionResult Edit(int id)
        {
            return View(dao.Find(id));
        }

        // POST: Weapon/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm]WeaponModel wep)
        {
            try
            {
                wep.ID = id;
                dao.Upsert(wep);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Weapon/Delete/5
        public ActionResult Delete(int id)
        {
            return View(dao.Find(id));
        }

        // POST: Weapon/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                dao.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}