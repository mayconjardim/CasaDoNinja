

using System.Net.Http.Json;

namespace CasaDoNinja.Client.Shared
{

     partial class ProductList
    {

        private static List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Product>>("api/products");
            if (result != null)
            {
                Products = result;
            }
        }

    }
}
