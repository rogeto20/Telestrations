using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class GameViewModel
    {
        [Display(Name = "Game Id")]
        [Required]
        public int GameID { get; set; }

        [Display(Name = "Owner")]
        public string Owner { get; set; }

        [Display(Name = "Game Name")]
        public string Name { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Number of Players")]
        public int NumPlayers { get; set; }
    }
}