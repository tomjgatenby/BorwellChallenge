using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BorwellChallenge.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}