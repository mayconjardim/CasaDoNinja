﻿using Microsoft.AspNetCore.Components;

namespace CasaDoNinja.Client.Pages
{
    partial class ProductDetails
    {

        private Product? product = null;
        private string message = string.Empty;

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
            }
        }

    }
}