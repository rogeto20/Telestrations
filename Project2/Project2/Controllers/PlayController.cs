using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class PlayController : Controller
    {

        public PlayController()
        {

        }
        // GET: Play
        public ActionResult Play()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
        public ActionResult Players(string id)
        {
            GameViewModel model = new GameViewModel();
            model.GameID = int.Parse(id);
            return View(model);
        }
    }
}