using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
     public class EmployeeController : Controller
     {
        public IActionResult Index1(){
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }
        public ViewResult Index2(){
            var names = new String[]{
                "Recep",
                "Sabri",
                "Furkan"
            };
            return View(names);
        }
        public IActionResult Index3(){
            var list = new List <Employee>(){
                new Employee (){
                    Id=1,
                    FirstName="Recep",
                    LastName="Yıldırım",
                    Age=24
                },
                new Employee (){
                    Id=2,
                    FirstName="Furkan",
                    LastName="özşirvan",
                    Age=21
                },
                new Employee (){
                    Id=3,
                    FirstName="SABRİ",
                    LastName="ÇAKIR",
                    Age=22
                }
            };
            return View("Index3",list);
        }
     }
}