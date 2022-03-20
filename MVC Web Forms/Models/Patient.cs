using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Web_Forms.Models
{
    public class Patient
    {
        public int id { get; set; }
        [Display(Name = "Name")]        
        public string name { get; set; }

        [Display(Name ="Temperature")]
        public float temp { get; set; }

        [Display(Name = "Allergies")]
        public string allergies { get; set; }
    }
}