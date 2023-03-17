using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using аряяяяяяяя.Models;
using аряяяяяяяя.Models.vm;

namespace аряяяяяяяя.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
        [HttpPost]
        public async Task<IActionResult> Index(UserNameViewModel vm)
        {
            List<double> time = new List<double> { 1.05, 1.898, 2.03 };
            User user = new User(1.27, vm.Name, time);
            int age = 18;
            return View(vm);
        }
    }
}
