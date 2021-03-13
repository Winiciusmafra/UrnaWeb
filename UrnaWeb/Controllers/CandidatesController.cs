using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaWeb.Controllers
{
    public class CandidatesController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
