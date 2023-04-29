
using CasaDoNinja.Shared;
using CasaDoNinja.Shared.Dtos;

namespace CasaDoNinja.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Carregando Produtos";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;


        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products/featured") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/category/{categoryUrl}");
            if (result != null && result.Data != null)
            { 
                Products = result.Data;
            }
            CurrentPage = 1;
            PageCount = 0;

            if (Products.Count == 0)
            {
                Message = "Nenhum produto encontrado!";
            }

            ProductsChanged.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{productId}");
            return result;
        }

        public async Task SeachProducts(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await _http.GetFromJsonAsync<ServiceResponse<ProductSearchDto>>($"api/products/search/{searchText}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if(Products.Count == 0)
            {
                Message = "Nenhum Produto Encontrado!";
            }
            ProductsChanged?.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {

            var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/products/searchsuggestions/{searchText}");
            return result.Data;

        }
    }
}
