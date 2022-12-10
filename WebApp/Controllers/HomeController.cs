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

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();

      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;       
            con.ConnectionString = "Data Source =.\\sqlexpress; Initial Catalog = myCarro; Integrated Security = True";
        }

        Sistema s = Sistema.Instancia;
        public IActionResult Index()
        {
            
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT TOP (1000) [ID],[Nombre],[Img],[Horarios],[Ubicacion],[Rating],[CTop] FROM[myCarro].[dbo].[Carro]";
            dr= com.ExecuteReader();
            while (dr.Read())
            {
                s.altaCarro(new Carro()
                {
                     id = Convert.ToInt32(dr["ID"]),
                     nombre = dr["Nombre"].ToString(),
                     img = dr["Img"].ToString(),
                     horarios = dr["Horarios"].ToString(),
                     ubicacion = dr["Ubicacion"].ToString(),
                     rating =dr["Rating"].ToString(),
                     top = Convert.ToInt32( dr["CTop"])

                });
            }

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
