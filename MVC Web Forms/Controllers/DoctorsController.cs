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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Doctor dc)
        {
            if( ModelState.IsValid)
            {
                hc.doctor.Add(dc);
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}