using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLGTest.DataHelpers;
using MLGTest.Entities;

namespace MLGTest.Controllers
{
    public class EmployeesCusotmController : Controller
    {
        private MLGDataContext _context { get; set; }
        public EmployeesCusotmController(MLGDataContext _context)
        {
            this._context = _context;
        }
        [Route("/GetEmoloyeesList")]
        public List<Employee> Index()
        {
            return _context.Employees.Include("Department").ToList();
        }
        [Route("/GetEngineersList")]
        public List<Employee> GetEngineers()
        {
            return _context.Employees.Where(x => x.Department.Name == "Engineering").Include("Department").ToList();
        }
    }
}
