using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCUI.Controllers
{
    public class CarteController : Controller
    {
        [Route("Carti")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Oferte")]
        public IActionResult Oferta()
        {
            return View();
        }
    }
}