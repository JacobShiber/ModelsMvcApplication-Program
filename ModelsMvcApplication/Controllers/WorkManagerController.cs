using ModelsMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsMvcApplication.Controllers
{
    public class WorkManagerController : Controller
    {
        // GET: WorkManager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetManagerName()
        {
            ViewBag.name = "Rami";
            return View();
        }

        public ActionResult GetManager()
        {
            return View();
        }

        public ActionResult GetManagersNames()
        {
            string[] names = new string[6] { "Rami", "Ram", "Ra", "R", "R R", "R R A" };
            return View(names);
        }

        public ActionResult GetManagers()
        {
            return View();
        }

        public ActionResult CreateManager()
        {
            WorkManger myManager = new WorkManger("Ramon", "Eliyahu", "Packaging");

            return View(myManager);
        }

        public ActionResult GetManagerList()
        {
            return View(CreateManagerList());
        }

        public List<WorkManger> CreateManagerList()
        {
            List<WorkManger> managerList = new List<WorkManger>();
            managerList.Add(new WorkManger("Ramon", "Eliyahu", "Packaging"));
            managerList.Add(new WorkManger("Tomer", "Avichail", "Delivery"));

            return managerList;
        }
    }
}