using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMVC.Controllers
{

    class Persona {
        public string name;
        public int edad;
    }
    public class TestController : Controller
    {
        // GET: /<controller>/
        public JsonResult Index()
        {
            var per = new Persona() { name = "calendula", edad = 3172138 };
            return Json(per);
        }

        public ContentResult StringMode()
        {
            string des = "<a>Aqui va la cosa </a>";
            return Content(des);
        }

        public ActionResult ModoDefault() {

            // return RedirectToRoute("default");
            return StatusCode(301);
        }
    }
}
