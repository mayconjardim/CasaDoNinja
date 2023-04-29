using Blazored.LocalStorage;

namespace CasaDoNinja.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            List<CartItem>? cart = await Cart();
            cart.Add(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange?.Invoke();
        }

     

        public async Task<List<CartItem>> GetCartItems()
        {
            return await Cart();
        }

        private async Task<List<CartItem>?> Cart()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;
        }
    }
}
