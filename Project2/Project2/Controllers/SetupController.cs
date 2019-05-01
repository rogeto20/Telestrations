using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    
    public class SetupController : Controller
    {
        [HttpPost]
        public JsonResult GetGames(int GameId)
        {
            try
            {
                using (var db = new Project())
                {
                    var result = db.Games.Find(GameId);
                    var model = new GameViewModel();
                    model = result;
                    return Json(model);
                }

            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        //[HttpPost]
        //public JsonResult SaveNewGame(GameViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return Json(null);
        //        }

        //        using (var db = new Project())
        //        {
        //            var record = model.
                   
        //            db.Games.Add(record);
        //            db.SaveChanges();

        //            return Json(true);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
                
        //        return Json(ex.Message);
        //    }
        //}







        /**Views*/
        // GET: Setup
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