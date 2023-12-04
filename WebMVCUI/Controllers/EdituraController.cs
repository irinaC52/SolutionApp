using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCUI.Controllers
{
    public class EdituraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}