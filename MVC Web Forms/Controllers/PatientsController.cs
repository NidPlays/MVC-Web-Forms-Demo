using MVC_Web_Forms.Models;
using System;
using System.Collections.Generic;
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
    }
}