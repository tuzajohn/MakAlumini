using MakAlumini.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MakAlumini.Web.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        
    }
}