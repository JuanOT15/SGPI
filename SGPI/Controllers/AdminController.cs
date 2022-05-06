﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using SGPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class AdminController : Controller
    {
        private SGPI_DBContext context;

        public AdminController(SGPI_DBContext contexto)
        {
            context = contexto;
        }
        public IActionResult AdministrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdministrarUsuario(Usuario user)
        {
            var listaUsuario = context.Usuarios
                .Where(u => u.Documento.Contains(user.Documento)).ToList();
            return View(listaUsuario);
        }


        public IActionResult CrearUsuario()
        {
            ViewBag.idprograma = context.Programas.ToList();
            ViewBag.tipoDoc = context.TipoDocumentos.ToList();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            ViewBag.idprograma = context.Programas.ToList();
            ViewBag.tipoDoc = context.TipoDocumentos.ToList();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            context.Add(usuario);
            context.SaveChanges();
            return View();
        }


        public IActionResult MenuAdmin()
        {
            return View();
        }

    }
}
