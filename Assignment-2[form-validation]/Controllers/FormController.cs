using Assignment_2_form_validation_.Data;
using Assignment_2_form_validation_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2_form_validation_.Controllers
{
    public class FormController : Controller
    {
        public readonly ApplicationDbContext _db;

        public FormController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewData["CountryCodes"] = new List<string>() { "IN","US" };
            ViewData["Services"] = new List<string>() { "Service1", "Service2", "Service3" };
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormModel model)
        {
            if (ModelState.IsValid)
            {
                _db.formModels.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Success");
            }

            return View();
        }

    }
}
