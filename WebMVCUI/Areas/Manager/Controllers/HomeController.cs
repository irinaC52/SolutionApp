using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCUI.Areas_Manager_Controllers
{
    [Area("Manager")]
    public class HomeController : Controller
    {
        [Route("{area}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}