using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cesar.Models;

namespace cesar.Controllers
{
    public class CesarController : Controller
    {
         static string Alfa = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        public IActionResult Index(){
            return View();
        }
        public IActionResult Encriptar(CesarViewModel model)
        {
            ViewData["Mensaje"] = model.Mensaje;
            ViewData["Clave"] = model.Clave;
            return View(Cifrar(model.Mensaje, model.Clave));
        }

        public IActionResult Desencriptar()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

         static CesarViewModel Cifrar(String Mensaje, int Desplazamiento)
        {
            
            return new CesarViewModel();
        }



    }
}
