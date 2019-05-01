using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperCats.Models
{
    public class SuperCat
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Temperment { get; set; }
        public string Sound { get; set; }
        public string CoatColor { get; set; }
    }
}