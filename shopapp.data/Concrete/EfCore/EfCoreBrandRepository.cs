using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreBrandRepository : EfCoreGenericRepository<Brand, ShopContext>,IBrandRepository
    {

        
    }
}