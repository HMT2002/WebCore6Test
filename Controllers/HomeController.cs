using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using WebCore6Test.Models;

namespace WebCore6Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\mssqlserver01;Initial Catalog=SchoolDb;Integrated Security=True");

            sqlConnection.Open();

            using(SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = @"update Students set TEN = 'Nguyen Van B' where ID = 'ID1'";
                cmd.ExecuteNonQuery();
            }

            sqlConnection.Close();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}