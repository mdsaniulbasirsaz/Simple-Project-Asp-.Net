using Microsoft.AspNetCore.Mvc;
using PatientManagementApp.Data;
using PatientManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PatientManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HospitalDbContext _context;

        public HomeController(HospitalDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.ToListAsync();
            if (!patients.Any())
            {
                ViewData["Message"] = "No patients found in the database.";
            }
            return View(patients);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
