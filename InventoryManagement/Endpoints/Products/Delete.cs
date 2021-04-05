using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Products
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IProductRepository _repo;

        public Delete(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/products/{id:Guid}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeleteProduct(id);
            await _repo.Save();
            return Ok();
        }
    }
}