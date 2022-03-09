using MakAlumini.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MakAlumini.Web.Controllers
{
    public class AluminiController : Controller
    {
        private readonly ILogger<AluminiController> _logger;

        public AluminiController(ILogger<AluminiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            if(string.IsNullOrEmpty(id))
                return View();

            return View("single");
        }

        
    }
}