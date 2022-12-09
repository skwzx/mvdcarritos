using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration configuration;
      

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            configuration = configuration;
        }

        Sistema s = Sistema.Instancia;
        public IActionResult Index()
        {
            string connectionstring = "Data Source =.\\sqlexpress; Initial Catalog = myCarro; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("Select count(ID) from Carro", connection);
            int str = (int)com.ExecuteScalar();
            ViewBag.msg = str;
            connection.Close();

            List<Carro> carros = s.top10();
            return View(carros);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
