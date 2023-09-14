using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Gerekli alan giriniz!")]
        [StringLength(100)]
        [Display(Name = "Urun Adı")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Fiyat bilgisini zorunludur")]
        [Range(0, 100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        [Required]
        public int? CategoryId { get; set; }
    }
}
