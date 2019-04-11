using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class Project : DbContext
    {
        public DbSet<GameViewModel> Games { get; set; }
    }

    public class GameViewModel
    {
        public int ID { get; set; }
        public string owner { get; set; }
        public string category { get; set; }
        public int numPlayers { get; set; }
        public string name { get; set; }
    }

    
}