﻿
namespace CasaDoNinja.Client.Services.CartService
{
    public interface ICartService
    {

        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List<CartProductDto>> GetCartProducts();
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductDto product);
        Task StoreCartItems(bool emptyLocalCart);
        Task GetCartItemsCount();

    }
}
