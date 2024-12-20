using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class BrandManager : IBrandService
    {
        private  IBrandRepository _brandRepository;

        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public void Create(Brand entity)
        {
            _brandRepository.Create(entity);
        }

        public void Delete(Brand entity)
        {
            _brandRepository.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandRepository.GetById(id);
        }

        public void Update(Brand entity)
        {
            _brandRepository.Update(entity);
        }
    }
}