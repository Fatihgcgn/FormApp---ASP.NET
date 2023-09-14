using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Urun Adı")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]

        [Required]
        public int? CategoryId { get; set; }
    }
}
