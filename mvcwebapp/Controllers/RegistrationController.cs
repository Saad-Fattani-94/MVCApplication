using Microsoft.AspNetCore.Mvc;
using mvcwebapp.Models;
using mvcwebapp.Models.Entities;

namespace mvcwebapp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly DatabaseContext _context;
        public RegistrationController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            //Handle Submission
            return View();
        }
    }
}
