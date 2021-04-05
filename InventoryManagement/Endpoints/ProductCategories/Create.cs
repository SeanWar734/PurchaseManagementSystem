using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using InventoryManagement.Shared.ProductCategories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.ProductCategories
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateProductCategoryRequest>.WithoutResponse
    {
        private readonly IProductCategoryRepository _repo;
        public Create(IProductCategoryRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/productcategories")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateProductCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var ProductCategory = new ProductCategory
            {
                Name = request.Name
            };
            await _repo.Add(ProductCategory);
            await _repo.Save();
            return Ok(ProductCategory);
        }
    }
}