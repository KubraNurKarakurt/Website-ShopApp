using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }  
       
        // [Display(Name="Name",Prompt="Enter product name")]
        // [Required(ErrorMessage="Name zorunlu bir alan.")]
        // [StringLength(60,MinimumLength=5,ErrorMessage="Ürün ismi 5-10 karakter aralığında olmalıdır.")]
        public string Name { get; set; }     
       
        [Required(ErrorMessage="Url is a required field.")]  
        public string Url { get; set; }     
      
        // [Required(ErrorMessage="Price zorunlu bir alan.")]  
        // [Range(1,10000,ErrorMessage="Price için 1-10000 arasında değer girmelisiniz.")]
        public double? Price { get; set; } 
      
        [Required(ErrorMessage="Description is a required field.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Description must be between 5-100 characters.")]

        public string Description { get; set; }      
       
        [Required(ErrorMessage="ImageUrl is a required field.")]  
        public string ImageUrl { get; set; }  = string.Empty;
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }

        [Required(ErrorMessage = "Stock Quantity is a required field.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be a positive number.")]
        public int StockQuantity { get; set; }


    
       public int BrandId { get; set; }
       public string BrandName { get; set; }
        public List<Brand> Brands { get; set; }

    }
}