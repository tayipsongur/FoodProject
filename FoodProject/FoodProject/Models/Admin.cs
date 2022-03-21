using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(30,ErrorMessage ="Lütfen 30 karakter girişi yapınız")]
        public string UserName { get; set; }
        [StringLength(30, ErrorMessage = "Lütfen 30 karakter girişi yapınız")]
        public string Password { get; set; }
        [StringLength(1)]
         public string AdminRole { get; set; }

    }
}
