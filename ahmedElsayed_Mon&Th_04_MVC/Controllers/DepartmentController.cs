using Company.Reposatory.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ahmedElsayed_Mon_Th_04_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReposatory _departmentReposatory;

        public DepartmentController(IDepartmentReposatory departmentReposatory)
        {
            _departmentReposatory = departmentReposatory;
        }

        public IActionResult Index()
        {
            var departments = _departmentReposatory.GetAll();
            return View(departments);
        }
    }
}
