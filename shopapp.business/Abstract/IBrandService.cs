using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IBrandService
    {
       Brand GetById(int id);
        List<Brand> GetAll();
        void Create(Brand entity);
        void Update(Brand entity);
        void Delete(Brand entity); 

        
    }
}