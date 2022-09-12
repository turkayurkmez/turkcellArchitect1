
using shop.DTOs.Responses;

namespace shop.Business
{
    public interface IProductService
    {
        IList<ProductListResponse> GetProducts();
    }
}
