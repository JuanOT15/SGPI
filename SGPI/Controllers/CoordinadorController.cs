using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SGPI.Controllers
{
    public class CoordinadorController : Controller
    {
        private SGPI_DBContext context;

        public CoordinadorController(SGPI_DBContext contexto)
        {
            context = contexto;
        }

        public IActionResult Consultas()
        {
            Usuario us = new Usuario();
            return View(us);
        }

        [HttpPost]
        public IActionResult Consultas(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento) && u.Rol == 3);

            if (buscarUsuario != null)
            {
                return View(buscarUsuario.FirstOrDefault());
            }
            return View();
        }

        public IActionResult EntrevistaAdmision()
        {
            Usuario us = new Usuario();
            return View(us);
        }

        [HttpPost]
        public IActionResult EntrevistaAdmision(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento));

            if (buscarUsuario != null)
            {
                return View(buscarUsuario.FirstOrDefault());
            }
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
