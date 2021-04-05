using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using InventoryManagement.Shared.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Products
{
    public class Update : BaseAsyncEndpoint.WithRequest<UpdateProductRequest>.WithoutResponse
    {
        private readonly IProductRepository _repo;

        public Update(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/products/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateProductRequest request, CancellationToken cancellationToken = default)
        {

            var Product = new Product
            {
                Id = request.Id,
                ProductCategoryId = request.ProductCategoryId,
                Brand = request.Brand,
                Description = request.Description,
                Name = request.Name
            };

            _repo.UpdateProduct(Product);
            await _repo.Save();
            return Ok(Product);
        }
    }
}
