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
    public class Create : BaseAsyncEndpoint.WithRequest<CreateProductRequest>.WithoutResponse
    {
        private readonly IProductRepository _repo;
        public Create(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/products")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            var Product = new Product
            {
                ProductCategoryId = request.ProductCategoryId,
                Name = request.Name,
                Brand = request.Brand,
                Description = request.Description
            };
            await _repo.Add(Product);
            await _repo.Save();
            return Ok(Product);
        }
    }
}
