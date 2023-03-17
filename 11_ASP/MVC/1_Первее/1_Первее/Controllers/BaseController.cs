using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Первее.Controllers
{
    public class BaseController : Controller
    {
        [ActionName("B")][HttpGet] // переопределяю наименование действия и говорю, что он обрабатывает только Get запросы
        public string Index()
        {
            return "Hello from BASE controller!";
        }
        [NonAction] //запрещаю системе маршрутизации воспринимать публичный метод как действие
        public int GetAge()
        {
            return 11;
        }
    }
}
