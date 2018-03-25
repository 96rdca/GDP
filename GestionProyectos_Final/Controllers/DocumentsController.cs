using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionProyectos_Final.Controllers
{
    public class DocumentsController : Controller
    {
        public ActionResult ByProjects()
        {
            return View();
        }
    }
}