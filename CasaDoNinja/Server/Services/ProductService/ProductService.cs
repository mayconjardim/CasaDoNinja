namespace CasaDoNinja.Server.Services.ProductService
{
    public class ProductService : IProductService
    {

        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int productId)
        {
            var response = new ServiceResponse<Product>
            {
                Data = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId)
            };

            return response;
        }
    }
}
