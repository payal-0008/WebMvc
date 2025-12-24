using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["MetaTitle"] = "Home | Personal Portfolio";
            ViewData["MetaDescription"] =
                "Welcome to my personal portfolio showcasing my skills, projects and experience in web development.";
            ViewData["MetaKeywords"] =
                "portfolio, web developer, asp.net core, full stack developer";

            return View();
        }
        public IActionResult About()
        {
            ViewData["MetaTitle"] = "About Me | Personal Portfolio";
            ViewData["MetaDescription"] =
                "Know more about me, my journey, skills and experience as a web developer.";
            ViewData["MetaKeywords"] =
                "about me, developer profile, asp.net core developer";

            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            return View();
        }

        public IActionResult Contact()
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
