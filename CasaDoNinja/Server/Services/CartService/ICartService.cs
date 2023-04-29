using CasaDoNinja.Shared.Dtos;

namespace CasaDoNinja.Server.Services.CartService
{
    public interface ICartService
    {

        Task<ServiceResponse<List<CartProductDto>>> GetCartProductsAsync(List<CartItem> cartItems);
        
    }
}
