using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class CarroController : Controller
    {
        Sistema s = Sistema.Instancia;
        public IActionResult Index()
        {
            List<Carro> carros = s.top10();
            return View(carros);
        }

    }
}
