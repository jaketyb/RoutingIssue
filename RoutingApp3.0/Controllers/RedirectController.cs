using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoutingApp3.Controllers
{

    [Route("redirect/{someIdentifier}")]
    public class RedirectController : Controller
    {        
        [HttpGet]
        [Route("initroute")]
        public IActionResult InitRoute(string someIdentifier)
        {          
            return RedirectToAction("NextRoute", "Redirect");
        }

        [HttpGet]
        [Route("nextroute")]
        public IActionResult NextRoute(string someIdentifier)
        {
            Debug.WriteLine(someIdentifier);

            return View();
        }
    }
}
