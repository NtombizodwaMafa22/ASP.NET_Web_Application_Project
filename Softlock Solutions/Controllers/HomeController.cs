using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softlock_Solutions.Models;

namespace Softlock_Solutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SoftlockSolutionsContext db = new SoftlockSolutionsContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult searchWorkLife(int id)
        {
            //IEnumerable<EmployeeWorkLife> obj = db.EmployeeWorkLives.Find(id);
            //db.EmployeeWorkLives.Where

            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeWorkLives.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult searchAvailability(int id)
        {
            IEnumerable<AvailabilityOfEmployee> obj = (IEnumerable<AvailabilityOfEmployee>)db.AvailabilityOfEmployees.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult searchCurrentJobInfo(int id)
        {
            IEnumerable<CurrentJobInformation> obj = (IEnumerable<CurrentJobInformation>)db.CurrentJobInformations.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult searchEmployeeData(int id)
        {
            IEnumerable<Employee> obj = (IEnumerable<Employee>)db.Employees.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult searchPerfomance(int id)
        {
            IEnumerable<Perfomance> obj = (IEnumerable<Perfomance>)db.Perfomances.Find(id);
            return View(obj);
        }

        public IActionResult Perfomance()
        {
            IEnumerable<Perfomance> obj = db.Perfomances;
            return View(obj);
        }

        public IActionResult PerfomanceEdit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.Perfomances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult PerfomanceEdit(Perfomance obj)
        {
            if (ModelState.IsValid)
            {
                db.Perfomances.Update(obj);
                db.SaveChanges();
                return RedirectToAction("PerfomanceEdit");
            }
            return View(obj);
        }

        public IActionResult AddPerfomance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerfomance(Perfomance userCreated)
        {
            if (ModelState.IsValid)
            {
                db.Perfomances.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("Perfomance");
            }

            return View();
        }

        public IActionResult PerfomanceDelete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.Perfomances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult PerfomanceDelete(Perfomance obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.Perfomances.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Perfomance", "Home");
        }

        public IActionResult Worklife()
        {
            IEnumerable<EmployeeWorkLife> obj = db.EmployeeWorkLives;
            return View(obj);
        }

        public IActionResult WorklifeEdit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeWorkLives.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Worklife(int id)
        {
            IEnumerable<EmployeeWorkLife> obj = db.EmployeeWorkLives;
            obj = obj.Where(a => a.EmployeeNumber.Equals(id));
            var user = db.EmployeeWorkLives.Find(id);
            IEnumerable<EmployeeWorkLife> obj2 = (IEnumerable<EmployeeWorkLife>)user;
            return View(obj2);
        }

        [HttpPost]
        public IActionResult WorklifeEdit(EmployeeWorkLife obj)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeWorkLives.Update(obj);
                db.SaveChanges();
                return RedirectToAction("WorklifeEdit");
            }
            return View(obj);
        }

        public IActionResult AddWorkLife()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWorkLife(EmployeeWorkLife userCreated)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeWorkLives.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("Worklife");
            }

            return View();
        }

        public IActionResult WorklifeDelete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeWorkLives.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult WorklifeDelete(EmployeeWorkLife obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.EmployeeWorkLives.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Worklife", "Home");
        }

        public IActionResult CurrentJobInformation()
        {
            IEnumerable<CurrentJobInformation> obj = db.CurrentJobInformations;
            return View(obj);
        }

        public IActionResult CurrentjobEdit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.CurrentJobInformations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult CurrentjobEdit(CurrentJobInformation obj)
        {
            if (ModelState.IsValid)
            {
                db.CurrentJobInformations.Update(obj);
                db.SaveChanges();
                return RedirectToAction("CurrentjobEdit");
            }
            return View(obj);
        }

        public IActionResult AddCurrentJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCurrentJob(CurrentJobInformation userCreated)
        {
            if (ModelState.IsValid)
            {
                db.CurrentJobInformations.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("CurrentJobEdit");
            }

            return View();
        }

        public IActionResult CurrentjobDelete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.CurrentJobInformations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult CurrentjobDelete(CurrentJobInformation obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.CurrentJobInformations.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("CurrentjobInformation", "Home");
        }

        public IActionResult Availability()
        {
            IEnumerable<AvailabilityOfEmployee> obj = db.AvailabilityOfEmployees;
            return View(obj);
        }

        public IActionResult AvailabilityEdit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.AvailabilityOfEmployees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult AvailabilityEdit(AvailabilityOfEmployee obj)
        {
            if (ModelState.IsValid)
            {
                db.AvailabilityOfEmployees.Update(obj);
                db.SaveChanges();
                return RedirectToAction("AvailabilityEdit");
            }
            return View(obj);
        }

        public IActionResult AvailabilityDelete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.AvailabilityOfEmployees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult AddAvailability() {
            return View();
        }

        [HttpPost]
        public IActionResult AddAvailability(AvailabilityOfEmployee userCreated)
        {
            if (ModelState.IsValid)
            {
                db.AvailabilityOfEmployees.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("Availability");
            }

            return View();
        }

        [HttpPost]
        public IActionResult AvailabilityDelete(AvailabilityOfEmployee obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.AvailabilityOfEmployees.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Availability", "Home");
        }

        public IActionResult EmployeeData() {
            IEnumerable<Employee> obj = db.Employees;
            return View(obj);
        }

        public IActionResult EmployeeDataEdit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult EmployeeDataEdit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EmployeeDataEdit");
            }
            return View(obj);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee userCreated)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("EmployeeData");
            }

            return View();
        }

        public IActionResult EmployeeDataDelete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult EmployeeDataDelete(Employee obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.Employees.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("EmployeeData", "Home");
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
