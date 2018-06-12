using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centauri_Online.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Centauri_Online.Controllers
{
    public class CRDController : Controller
    {
        // GET: CRD
        public ActionResult Index()
        {
            return View();
        }

        // GET: Skill
        public ActionResult Skill()
        {
            return View();
        }
    }
}