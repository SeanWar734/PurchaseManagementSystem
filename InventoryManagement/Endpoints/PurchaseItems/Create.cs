using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using InventoryManagement.Shared.PurchaseItems;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.PurchaseItems
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreatePurchaseItemRequest>.WithoutResponse
    {
        private readonly IPurchaseItemRepository _repo;
        public Create(IPurchaseItemRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/purchaseitems")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreatePurchaseItemRequest request, CancellationToken cancellationToken = default)
        {
            var PurchaseItem = new PurchaseItem
            {
                Id = request.Id,
                ProductId = request.ProductId,
                PurchaseId = request.PurchaseId,
                Notes = request.Notes,
                Price = request.Price,
                Quantity = request.Quantity,
                UOM = (Core.UnitOfMeasure)request.UOM
            };
            await _repo.Add(PurchaseItem);
            await _repo.Save();
            return Ok(PurchaseItem);
        }
    }
}
