using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoredProcedure.Data_Access;
using StoredProcedure.Models;
using System.Data;
using System.Diagnostics;

namespace StoredProcedure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DefaultDbContext _defaultDbContext;
        public HomeController(ILogger<HomeController> logger, DefaultDbContext defaultDbContext)
        {
            _logger = logger;
            _defaultDbContext = defaultDbContext;
        }
       
        public void GetData(string Email)
        {

            //SQL PARAMETER WRITING
            SqlParameter parameter = new SqlParameter("@i_email", SqlDbType.VarChar);
            parameter.Value = "a1@gmail.com";                   
            var empRecord = _defaultDbContext.RetrieveEmployeeDetails.FromSqlRaw("EXECUTE dbo.GetEmpDetailsFromEmail  @i_email", parameter).ToList();           
               
         }

        public IActionResult Index()
        {

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