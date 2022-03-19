using MVC_Web_Forms.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Forms.Controllers
{
    public class DoctorsController : Controller
    {
        //CRUD create, read, update, delete
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
            if (ModelState.IsValid)
            {
                hc.doctor.Add(dc);
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(hc.doctor.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Doctor dc = hc.doctor.Find(id);
            hc.doctor.Remove(dc);
            hc.SaveChanges();
            return RedirectToAction(nameof(Index));
            //return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(hc.doctor.Find(id));
        }
 
        [HttpPost, ActionName("Edit")]
        public ActionResult EditPost(Doctor dc)
        {
            if(ModelState.IsValid)
            {
                hc.Entry(dc).State = EntityState.Modified;
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(hc);
        }
    }
}