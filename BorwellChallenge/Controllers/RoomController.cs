using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorwellChallengeTests.Models;
using Microsoft.AspNetCore.Mvc;

namespace BorwellChallenge.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Main(decimal width = 0, decimal length = 0,decimal height = 0)
        {
            Room myRoom = new Room(width, length, height);
            return View(myRoom);
        }
    }
}