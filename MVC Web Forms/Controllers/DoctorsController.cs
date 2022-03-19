using MVC_Web_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Forms.Controllers
{
    public class DoctorsController : Controller
    {
        HospitalContext hc = new HospitalContext();
        // GET: Doctors
        public ActionResult Index()
        {
            List<Doctor> dlist = hc.doctor.ToList();
            return View(dlist);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}