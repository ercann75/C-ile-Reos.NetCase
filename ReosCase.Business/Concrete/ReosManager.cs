using ReosCase.Business.Abstract;
using ReosCase.DataAccess.Abstract;
using ReosCase.DataAccess.Concrete;
using ReosCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReosCase.Business.Concrete
{
    public class ReosManager : IReosService
    {
        private IReosRepository _reosRepository;

        public ReosManager()
        {
            _reosRepository = new ReosRepository();
        }

        public Product CreateProduct(Product product)
        {
            return _reosRepository.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _reosRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _reosRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            if (id>0)
            {
                return _reosRepository.GetProductById(id);
            }
            throw new Exception("Id can not be less than 1.");
        }

        public Product UpdateProduct(Product product)
        {
            return _reosRepository.UpdateProduct(product);
        }
    }
}
