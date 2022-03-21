using FoodProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x => x.CategoryName == p));
            }
            var listele = categoryRepository.TList();
            return View(listele);
              
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult CategoryAdd(Category p)
        {

            if (!ModelState.IsValid)
            {

                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);             
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult CategoryGet(int id)
        {
            var degerbul = categoryRepository.TGet(id);

            List<string> liste = new List<string>();
            {
                liste.Add("True");
                liste.Add("False");
            }

            List<SelectListItem> deger = (from i in liste.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.ToString(),
                                              Value = i.ToString()

                                          }).ToList();

            ViewBag.dgr = deger;

            return View(degerbul);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            categoryRepository.TUpdate(p);
            return RedirectToAction("Index");           
        }
       
        public IActionResult CategorySil(int id)
        {
            var gelenid = categoryRepository.TGet(id);
            Category category = new Category();
        
            category = gelenid;
            category.Status = category.Status == true ? false : true;

            categoryRepository.TUpdate(category);

            return RedirectToAction("Index");
        }
        public IActionResult CategoryPassive()
        {
            var listele = categoryRepository.TList();
            return View(listele);

        }

        public IActionResult CategoryPassive2(int id)
        {
            Category category = new Category();
            var gelenid = categoryRepository.TGet(id);

            category = gelenid;
            category.Status = category.Status == true ? false : true;

            categoryRepository.TUpdate(category);

            return RedirectToAction("CategoryPassive");



        }



    }
}
