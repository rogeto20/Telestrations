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
        private Project db;
        public PlayController()
        {
            db = new Project();
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
            var gameId = int.Parse(id);
             var result = db.Games.Find(gameId);

                    var model = new GameViewModel
                    {
                        GameID = gameId
                    };


                    return View(model);

           
        }
    }
}