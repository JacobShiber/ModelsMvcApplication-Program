using ModelsMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsMvcApplication.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetWorkerName()
        {
            ViewBag.name = "Jacob";
            return View();
        }

        public ActionResult GetWorker()
        {
            return View();
        }

        public ActionResult GetWorkersNames()
        {
            string[] names = new string[6] {"Jacob", "Jaco", "Jac", "Ja", "J", "J J" };
            return View(names);
        }

        public ActionResult GetWorkers()
        {
            return View();
        }

        public ActionResult CreateWorker()
        {
            Worker myWorker = new Worker();
            myWorker.FirstName = "Ron";
            myWorker.LastName = "Shevi";
            myWorker.BirthYear = 1991;
            myWorker.PhoneNumber = 5555;

            return View(myWorker);
        }
    }
}