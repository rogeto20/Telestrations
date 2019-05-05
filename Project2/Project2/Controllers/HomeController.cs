using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {

         //using (var db = new RPT_SyngoWorkflowEntities())
         //       {
         //           var result = db.ResearchProjects.Find(projectID);
         //           var model = Mapper.Map<ResearchProjectViewModel>(result);
         //           return Json(new AjaxResponse(model, true));
         //       }


        [HttpPost]
        public JsonResult GetGames(string Owner)
        {
            Owner = "romeogeto@gmail.com";
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Game, GameViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            
            try
            {
                using (var db = new ProjectEntities())
                {
                    var result = db.Games.Where(u => u.owner == Owner).AsQueryable().ToList();
                    var model = mapper.Map<List<Game>, List<GameViewModel>>(result);
                    return Json(model);
                }

            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpPost]
        public JsonResult SaveNewGame(GameViewModel model)
        {
            try
            {
                using (var db = new ProjectEntities())
                {
                    Random random = new Random();
                    var num =  random.Next(999, 10000);

                    while(db.Games.Any( u => u.Id == num))
                    {
                        num = random.Next(999, 10000);
                    }

                    model.ID = num;
                    
                    if (!ModelState.IsValid)
                     {
                        return Json(null);
                     }

                    Owner owner = new Owner
                    {
                        gameId = model.ID,
                        email = model.owner
                    };

                    db.Owners.Add(owner);
                    db.SaveChanges();
              

                    Game game = new Game
                    {
                        Id = model.ID,
                        name = model.name,
                        category = model.category,
                        numPlayers = model.numPlayers,
                        owner = model.owner
                    };

                    db.Games.Add(game);
                    db.SaveChanges();

                    
                    Player players = new Player
                    {
                        name = model.name,
                        position = db.Players.Count(u=> u.gameId == model.ID),
                        gameId = model.ID
                    };

                    db.Players.Add(players);
                    db.SaveChanges();
                    return Json(true);
                }

            }
            catch (Exception ex)
            {

                return Json(ex.Message);
            }
        }

        /**
         * Views
        /*******************************************************************************************************************/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Preview()
        {
            return View();
        }

        public ActionResult Play()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
        public ActionResult Players(int gameId)
        {

            using (var db = new ProjectEntities())
            {
                var result = db.Games.Find(gameId);

                var model = new GameViewModel
                {
                    ID = gameId
                };

                return View(model);
            }



        }
    }
}