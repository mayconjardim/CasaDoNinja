﻿namespace CasaDoNinja.Client.Services.ProductService
{
    public interface IProductService
    {

        event Action ProductsChanged;

        string Message { get; set; }
        List<Product> Products { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);
        Task SeachProducts(string searchText, int page);
        Task<List<string>> GetProductSearchSuggestions(string searchText);

    }
}
