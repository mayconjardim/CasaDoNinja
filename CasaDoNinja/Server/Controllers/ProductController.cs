﻿using CasaDoNinja.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoNinja.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
           
            var result = await _productService.GetProductsAsync();
            return Ok(result);

        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int productId)
        {

            var result = await _productService.GetProductByIdAsync(productId);
          
            return Ok(result);

        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductByCategory(string categoryUrl)
        {

            var result = await _productService.GetProductsByCategoryAsync(categoryUrl);

            return Ok(result);

        }


    }
}
