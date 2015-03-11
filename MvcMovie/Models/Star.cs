using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Star
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int AspNetUsersId { get; set; }
        [Range(0, 5)]
        public int Stars { get; set; }
    }
}