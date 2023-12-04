using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCUI.Areas_Admin_Controllers
{
    [Area ("Admin")]
    public class HomeController : Controller
    {
        [Route("{area}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}