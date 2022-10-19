using System.Collections.Generic;
using NetCoreFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreFirstApp.Controllers
{
    public class HomePageController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult List(){
            Students student1 = new Students(1,"Burak","Bahceci",4);
            Students student2 = new Students(2,"Safa","Burak",3);
            Students student3 = new Students(3,"Basak","Bozkurt",1);
            Students student4 = new Students(4,"Safa","Bahceci",3);
            Students student5 = new Students(5,"Basak","Bahceci",4);

            var list = new List<Students>();
            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            list.Add(student4);
            list.Add(student5);

            return View(list);
        }
    }
}