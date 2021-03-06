using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Vendors
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IVendorRepository _repo;

        public Delete(IVendorRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/vendors/{id:Guid}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeletePurchase(id);
            await _repo.Save();
            return Ok();
        }
    }
}