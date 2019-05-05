using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class PlayerViewModel
    {
        [Display(Name = "Game Id")]
        public int position { get; set; }

        [Display(Name = "Owner")]
        public string name { get; set; }

        [Display(Name = "Game Name")]
        public int gameId { get; set; }
    }
}