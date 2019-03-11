using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Telestrations.Controllers
{
    public class PlayController : Controller
    {
        // GET: Play
        public ActionResult Play()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
    }
}