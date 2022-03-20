using MVC_Web_Forms.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Forms.Controllers
{
    public class PatientsController : Controller
    {
        // GET: Patients
        HospitalContext hc = new HospitalContext();
        public ActionResult Index()
        {
            List<Patient> plist = hc.patient.ToList();
            return View(plist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient pc)
        {
            if(ModelState.IsValid)
            {
                hc.patient.Add(pc);
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(hc.patient.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Patient pc = hc.patient.Find(id);
            hc.patient.Remove(pc);
            hc.SaveChanges();
            return RedirectToAction(nameof(Index));
            //return View();
        }

        public ActionResult Edit(int id)
        {
            return View(hc.patient.Single(x => x.id==id));
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditPost(Patient pc)
        {
            if (ModelState.IsValid)
            {
                hc.Entry(pc).State = EntityState.Modified;
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }   
            return View(hc);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(hc.patient.Single(x => x.id == id));
        }
    }
}