using MakAlumini.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MakAlumini.Web.Controllers
{
    public class NewsLettersController : Controller
    {
        private readonly ILogger<AluminiController> _logger;

        public NewsLettersController(ILogger<AluminiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            if(string.IsNullOrEmpty(id))
                return View();

            return View("single");
        }

        public IActionResult NewPublication()
        {
            return View();
        }
        public IActionResult Editpublication(string id)
        {

            return View("NewPublication");
        }



        
    }
}