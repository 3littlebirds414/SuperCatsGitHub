using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperCats.Models
{
    public class SuperDog
    {
        [Key]
        public int Id { get; set; }
        public int TagNumber { get; set; }
        public string Sound { get; set; }
    }
}