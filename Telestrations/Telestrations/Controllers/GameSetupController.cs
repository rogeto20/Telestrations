using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Telestrations.Controllers
{
    public class GameSetupController : Controller
    {
        // GET: GameSetup
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Preview()
        {
            return View();
        }
    }
}