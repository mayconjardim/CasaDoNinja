using Microsoft.AspNetCore.Components;

namespace CasaDoNinja.Client.Pages
{
    partial class ProductDetails
    {

        private Product? product = null;
        private string message = string.Empty;
        private int currentTypeId = 1;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
           message = "Carregando Produto...";

           var result = await ProductService.GetProductById(Id);
           if (!result.Success) 
            { 
                message = result.Message;
            }
            else
            {
                product = result.Data;
                if (product.Variants.Count > 0)
                {
                    currentTypeId = product.Variants[0].ProductTypeId;
                }
            }
        }

        private ProductVariant GetSelectedVariant()
        {
            var variant = product.Variants.FirstOrDefault(v => v.ProductTypeId == currentTypeId);
            return variant;
        }

    }
}
