namespace CasaDoNinja.Client.Shared
{

     partial class ProductList
    {

        private static List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
         
        }

    }
}
