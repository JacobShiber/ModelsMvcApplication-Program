using ModelsMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsMvcApplication.Controllers
{
    public class SuperviserController : Controller
    {
        // GET: Superviser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSupervisorName()
        {
            ViewBag.name = "Sami";
            return View();
        }

        public ActionResult GetSupervisor()
        {
            return View();
        }

        public ActionResult GetSupervisorsNames()
        {
            string[] names = new string[6] { "Sami", "Sam", "Sa", "S", "S S", "S S A" };
            return View(names);
        }

        public ActionResult GetSupervisors()
        {
            return View();
        }

        public ActionResult CreateSupervisor()
        {
            SuperVisor mySupervisor = new SuperVisor("Tom", "Hank", 1985, 13);

            return View(mySupervisor);
        }

        public ActionResult GetSupervisorList()
        {
            return View(CreateSuperVisorList());
        }

        public List<SuperVisor> CreateSuperVisorList()
        {
            List<SuperVisor> supervisorsList = new List<SuperVisor>();
            supervisorsList.Add(new SuperVisor("John", "Doe", 1989, 5));
            supervisorsList.Add(new SuperVisor("Sam", "Monoco", 1993, 3));
            supervisorsList.Add(new SuperVisor("Anthony", "Davis", 1985, 11));
            supervisorsList.Add(new SuperVisor("Kevin", "Durant", 1988, 13));

            return supervisorsList;
        }
    }
}