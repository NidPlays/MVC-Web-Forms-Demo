using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Web_Forms.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public DateTime appointDate { get; set; }

        [ForeignKey("pt")]
        public int ptID { get; set; }

        public Patient pt { get; set; }

        [ForeignKey("doc")]
        public int docID { get; set; }

        public Doctor doc { get; set; }

        public string ptEmail { get; set; }


    }


}