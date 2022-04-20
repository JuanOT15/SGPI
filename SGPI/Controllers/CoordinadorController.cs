using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class CoordinadorController : Controller
    {
        public IActionResult Consultas()
        {
            return View();
        }

        public IActionResult EntrevistaAdmision()
        {
            return View();
        }
        public IActionResult HomologacionAsignatura()
        {
            return View();
        }
        public IActionResult ProgramarAsignatura()
        {
            return View();
        }
        public IActionResult MenuCoordinador()
        {
            return View();
        }


    }
}
