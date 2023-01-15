using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReosCase.Business.Abstract;
using ReosCase.Business.Concrete;
using ReosCase.Entities;

namespace ReosCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IReosService _reosService;

        public ProductsController()
        {
            _reosService = new ReosManager() ;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _reosService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _reosService.GetProductById(id);
        }

        [HttpPost]
        public Product Post([FromBody]Product product)
        {
            return _reosService.CreateProduct(product);
        }

        [HttpPut]
        public Product Put([FromBody] Product product)
        {
            return _reosService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
           _reosService.DeleteProduct(id);
        }

    }
}
