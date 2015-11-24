using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Http;

namespace Orebranch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel();
            return View(model);
        }

        [Route("webapi/message")]
        public HomeViewModel Get()
        {
            return new HomeViewModel();
        }
    }

    public class HomeViewModel
    {
        public string Message { get; set; } = "Hello World!";
    }
}
