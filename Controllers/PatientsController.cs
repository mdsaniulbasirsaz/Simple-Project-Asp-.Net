using Microsoft.AspNetCore.Mvc;
using PatientManagementApp.Data;
using PatientManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PatientManagementApp.Controllers
{
    public class PatientsController : Controller
    {
        private readonly HospitalDbContext _context;

        public PatientsController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: /Patients/Index
        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.ToListAsync();
            return View(patients);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return Json(new { success = false, message = "Patient not found!" });
            }

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Patient deleted successfully!" });
        }


    }
}
