using ReosCase.DataAccess.Abstract;
using ReosCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReosCase.DataAccess.Concrete
{
    public class ReosRepository : IReosRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var reosDbContext = new ReosDbContext())
            {
                reosDbContext.Products.Add(product);
                
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var reosDbContext = new ReosDbContext())
            {
                var deletedProduct = GetProductById(id);
                reosDbContext.Products.Remove(deletedProduct);
                reosDbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var reosDbContext = new ReosDbContext())
            {
                return reosDbContext.Products.ToList();
            }
        }

        public Product GetProductById(int id)
        {
            using (var reosDbContext = new ReosDbContext())
            {
                return reosDbContext.Products.Find(id);
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var reosDbContext = new ReosDbContext())
            {
                reosDbContext.Products.Update(product);
                reosDbContext.SaveChanges();
                return product;
            }
        }
    }
}
