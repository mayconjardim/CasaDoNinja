namespace CasaDoNinja.Client.Shared
{

     partial class ProductList
    {

        protected override void OnInitialized()
        {
            ProductService.ProductsChanged += StateHasChanged;
         
        }

        public void Dispose()
        {
            ProductService.ProductsChanged -= StateHasChanged;

        }


        private string GetPrice(Product product)
        {
            var variants = product.Variants;
            if (variants.Count == 0)
            {
                return string.Empty;
            }
            else if (variants.Count == 1)
            {
                return $"R$ {variants[0].Price}";
            }
            decimal minPrice = variants.Min(x => x.Price);
            return $"Apartir de R$ {minPrice}";

        }
    }
}
