using CasaDoNinja.Shared.Dtos;

namespace CasaDoNinja.Server.Services.ProductService
{
    public interface IProductService
    {

        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductByIdAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
        Task<ServiceResponse<ProductSearchDto>> SearchProductsAsync(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestionsAsync(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();

    }
}
