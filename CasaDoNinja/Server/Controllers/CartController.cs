﻿using CasaDoNinja.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoNinja.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = await _cartService.GetCartProducts(cartItems);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> StoreCartItems(List<CartItem> cartItems)
        {
            var result = await _cartService.StoreCartItems(cartItems);
            return Ok(result);
        }

        [HttpGet("count")]
        public async Task<ActionResult<ServiceResponse<int>>> GetCartItemsCount()
        {
            return await _cartService.GetCartItemsCount();
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<int>>> GetDbCartProducts()
        {
            var result = await _cartService.GetDbCartProducts();
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddToCart(CartItem cartItem)
        {
            var result = await _cartService.AddToCart(cartItem);
            return Ok(result);
        }

    }
}
