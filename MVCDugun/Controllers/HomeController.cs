using MVCDugun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDugun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slider() //<div id=home>
        {
            return View();
        }

        public ActionResult Story()
        {
            return View();
        }

        public ActionResult Timer()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Wedding()
        {
            return View();
        }
        [HttpGet] //formu gösteren kısım
        public ActionResult Rezervasyon()
        {
            return View();
        }
        [HttpPost] //formu kaydeden kısım
        public ActionResult Rezervasyon(Rezervasyon r)
        {
            if (ModelState.IsValid)
            {
                r.IP = Request.ServerVariables["REMOTE_ADDR"];
                DugunContext ctx = new DugunContext();
                ctx.Rezervasyonlar.Add(r);
                ctx.SaveChanges();
                ViewBag.sonuc = "TesekkurEt();";
            }
            return View();
        }
    }
}