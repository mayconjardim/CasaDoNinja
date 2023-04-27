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
    }
}
