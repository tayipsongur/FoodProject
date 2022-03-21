using FoodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.Controllers
{
    
    public class ChartController : Controller
    {
        
           public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult VisualizeProductResult2() // Ürün sonuçlarını görselleştir.
        {
            return Json(FoodList()); 

        }
        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2
                {
                    FoodName = x.FoodName,
                    Stock = x.Stock

                }).ToList();
            
            }
            return cs2;
        }


        public IActionResult VisualizeProductResult() // Ürün sonuçlarını görselleştir.
        {
            return Json(ProList()); 

        }


        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {

                proname ="Computer",
                stock=150
            });

             cs.Add(new Class1()
            {

                proname = "LCD",
                stock=75
            });

             cs.Add(new Class1()
            {

                proname = "USB Disk",
                stock=350
            });

            return cs; 

        }


   

        
    }
}
