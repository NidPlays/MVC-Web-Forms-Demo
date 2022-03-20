using MVC_Web_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Forms.Controllers
{
    public class AppointmentsController : Controller
    {
        HospitalContext hc = new HospitalContext();
        // GET: Appointment
        public ActionResult Index()
        {
            //List<Appointment> aptlists = hc.apt.Include()
            return View(hc.apt.Include("doc").Include("pt").ToList());
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.docID = new SelectList(hc.doctor.ToList(), "id", "name");
            ViewBag.ptID = new SelectList(hc.patient.ToList(),"id", "name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Appointment apt)
        {
            if(ModelState.IsValid)
            {
                apt.ptEmail = "1rn19is094@rnsit.ac.in";
                hc.apt.Add(apt);
                hc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}