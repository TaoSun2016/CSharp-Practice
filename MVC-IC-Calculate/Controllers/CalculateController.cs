using MVC_IC_Calculate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_IC_Calculate.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include ="Height,Width")] Operant operant)
        {
            if (ModelState.IsValid)
            {
                operant.Area = string.Format("squre is {0}",operant.Height*operant.Width);
            }
            return View(operant);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int ? arg1, int ? arg2)
        {
            ViewBag.arg3 = arg1 + arg2;
            return View();
        }
    }
}