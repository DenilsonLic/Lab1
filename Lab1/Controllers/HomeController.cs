using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(ActionNotas notas)
        {
            ViewBag.l1 = notas.Lab1;
            ViewBag.l2 = notas.Lab2;
            ViewBag.l3 = notas.Lab3;
            ViewBag.p1 = notas.Par1;
            ViewBag.p2 = notas.Par2;
            ViewBag.p3 = notas.Par3;
            Double promLab = ((notas.Lab1+notas.Lab2+notas.Lab3)/3)*0.40;
            Double promPar = ((notas.Par1+notas.Par2+notas.Par3)/3)*0.60;
            Double promFinal= promLab + promPar;
            ViewBag.promf = promFinal;
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}