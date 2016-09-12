using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INEQ.Controllers
{
   
        public class CatalagoDeEquipoController : Controller
        {
        public ActionResult Index()
        {  
            ViewData["Descripcion"] = "valor";
            ViewData["vida util"] = "valor";
            ViewData["]Duracion de garantia"] = "valor";
            ViewData["activo"] = "valor";
            return View();
        }
    }
    }
}