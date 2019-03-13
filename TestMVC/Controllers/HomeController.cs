using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMVC.InfoServices;
using TestMVC.Models;
using reference;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //creamos un objeto para usar la funcio que nos devuelte informacion asi delegamos funcionalidaddes a otras clases
            var paisService = new InfoPaises();

            //usamo dicha funcio que en este caso devuelve un pais
            var model = paisService.ObetenerPais();
            var model2 = paisService.ObetenerPaises();


            //enviamos la info a la vista index
            return View(model2);
        }

        public IActionResult Nonithing()
        {
            ViewData["Mest"] = "Holats Vengo de la ruta Nonithing.";
            //tambien podemos tomar la informaccion de una aplicacion de wcf de la siguiente forma

            PaisServiceClient client = new PaisServiceClient();

            var des = client.MetodoTestPaisAsync(1);

            return View(des);
        }
                    
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            CountryWebService info = new CountryWebService();

            string des = info.ObtenerCountry();

            ViewBag.info = des;

            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact(string nombre)
        {
            ViewData["Message"] = "Your contact page." + nombre;

            return View();
        }

        public IActionResult Privacy()
        {

            ClienteCalculator cl = new ClienteCalculator();

            int res = (int)cl.operacion(ClienteCalculator.operacion_tipo.suma,1,1);

            return View(res);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
