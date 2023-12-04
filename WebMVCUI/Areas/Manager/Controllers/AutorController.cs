using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVCUI.DTOs.Autor;

namespace WebMVCUI.Areas_Manager_Controllers
{
    [Area("Manager")]
    public class AutorController : Controller
    {
        [Route("{area}/autori")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{area}/{controller}/{action}")]
        public IActionResult Adauga()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adauga(AutorNouDto autorNou)
        {
            if(ModelState.IsValid){
                Console.WriteLine("Aici salvam in baza de date..");
            }
                Console.WriteLine("Aici NU salvam in baza de date..");
            return View();
        }
    }
}