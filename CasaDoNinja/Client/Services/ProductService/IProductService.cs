namespace CasaDoNinja.Client.Services.ProductService
{
    public interface IProductService
    {

        event Action ProductsChanged;

        string Message { get; set; }
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);
        Task SeachProducts(string searchText);
        Task<List<string>> GetProductSearchSuggestions(string searchText);

    }
}
