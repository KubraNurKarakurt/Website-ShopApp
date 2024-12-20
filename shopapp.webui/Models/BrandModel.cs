using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class BrandModel
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        //  public List<Product> Products { get; set; }
        public List<ProductModel> Products { get; set; }
    }

        public class BrandListViewModel
    {
        public List<Brand> Brands { get; set; }
       
    }
}