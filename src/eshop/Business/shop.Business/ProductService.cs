using eshop.Data.Repositories;
using shop.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Business
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IList<ProductListResponse> GetProducts()
        {
            var products = _repository.GetEntities();
            return products.Select(p => new ProductListResponse { Id = p.Id, Name = p.Name }).ToList();
        }
    }
}
