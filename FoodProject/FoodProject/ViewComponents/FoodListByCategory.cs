﻿using FoodProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {

        // Bu classta istediğimiz kategoriye göre ürünlerin listesini getiriyoruz. 
        // GenericRepository içerisindeki List metodunu incele.
        public IViewComponentResult Invoke(int id)
        {

            FoodRepository foodRepository = new FoodRepository();

            var foodList = foodRepository.List(x => x.CategoryID == id);
            return View(foodList);

        }

    }
}
