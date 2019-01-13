using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Centauri_Online.Models.VehicleCreation;
using Centauri_Online.Models;

namespace Centauri_Online.Controllers
{
    public class VehicleCreationController : Controller
    {
        // GET: VehicleCreation
        public ActionResult Index()
        {

            var cores = new List<PowerCore>()
            {
                // Power Core Size CRS (1/2)
                new PowerCore(
                    1,
                    .5d,
                    8,
                    3,
                    0,
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                    10,
                    1,
                    15000),

                // Power Core Size CRS (1)
                new PowerCore(
                    1,
                    1d,
                    8,
                    5,
                    1,
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                    10,
                    2,
                    30000)
            };

            return View(
                new VehicleCreationViewModel
                {
                    PowerCores = cores
                }
            );
        }

        // GET: VehicleCreation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleCreation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleCreation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleCreation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleCreation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleCreation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleCreation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}