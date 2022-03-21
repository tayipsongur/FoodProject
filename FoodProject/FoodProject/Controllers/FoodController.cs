using FoodProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace FoodProject.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
           
            return View(foodRepository.TList("Category").ToPagedList(page,10));  // Category tablosundan ihtiyacımız olan veriyi çekmek için Inculede metodunu kullandığımız için
            // Burada listelerden Category tablosununda listelenmesini sağladık. ToPadegList ile sayfalama işlemi yaptık.
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> kategori = (from i in c.Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryID.ToString()

                                             }).ToList();

            ViewBag.ktg = kategori;
            return View();
        }
        [HttpPost]

        public IActionResult FoodAdd(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");

        }
        public IActionResult FoodDelete(int id)
        {

            foodRepository.TDelete(new Food { FoodID = id }); // AspNet'teki context sınıfından nesne türeterek yaptığımız işlemi de kullanabiliriz
                                                              // bu yöntemi de kullanabiliriz. İki yöntemde silme işlemini gerçekleştirir.

            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public IActionResult FoodUpdate(int id)
        {
     
            List<SelectListItem> deger = (from i in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.CategoryName,
                                              Value = i.CategoryID.ToString()

                                          }).ToList();


            ViewBag.dgr = deger;
            var get = foodRepository.TGet(id);
            return View(get);
        }
        [HttpPost]
        public IActionResult FoodUpdate(Food p)
        {
            foodRepository.TUpdate(p);

            return RedirectToAction("Index");
        }



    }
}
