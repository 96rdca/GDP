using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionProyectos_Final.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Prjects
        public ActionResult Index()
        {
            return View();
        }

        // Add Prjects
        public ActionResult AddProject()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}