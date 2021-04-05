using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.PurchaseItems
{
    public class Delete : BaseAsyncEndpoint.WithRequest<Guid>.WithoutResponse
    {
        private readonly IPurchaseItemRepository _repo;

        public Delete(IPurchaseItemRepository repo)
        {
            _repo = repo;
        }

        [HttpDelete("/purchaseitems/{id:Guid}")]
        public override async Task<ActionResult> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _repo.DeletePurchaseItem(id);
            await _repo.Save();
            return Ok();
        }
    }
}
