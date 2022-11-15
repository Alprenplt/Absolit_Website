using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJEM.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DogalTaslar()
        {


            return View();
        }

        public ActionResult Burclar()
        {


            return View();
        }
        public ActionResult GırısYap()
        {


            return View();
        }
        public ActionResult UyeOl()
        {


            return View();
        }
        public ActionResult Iletısım()
        {


            return View();
        }
        public ActionResult Spinel()
        {


            return View();
        }
        public ActionResult Akik()
        {


            return View();
        }

        public ActionResult Akuamarin()
        {


            return View();
        }

        public ActionResult Barit()
        {


            return View();
        }


        public ActionResult Gunestası()
        {


            return View();
        }

        public ActionResult KaplanGözü()
        {


            return View();
        }

        public ActionResult İyolit()
        {


            return View();
        }

        public ActionResult Mercan()
        {


            return View();
        }


















    }
}
