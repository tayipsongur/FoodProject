using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Kategori Adı Boş Geçilemez")]
        [StringLength(30,ErrorMessage ="Lütfen 30 Karakterden Fazla Veri Girişi Yapmayınız.!")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set; }  // bire çok ilişkide çok olan taraf için
    }
}
