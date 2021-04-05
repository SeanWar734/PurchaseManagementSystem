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
    public class Update : BaseAsyncEndpoint.WithRequest<UpdatePurchaseItemRequest>.WithoutResponse
    {
        private readonly IPurchaseItemRepository _repo;

        public Update(IPurchaseItemRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/purchaseitems/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdatePurchaseItemRequest request, CancellationToken cancellationToken = default)
        {

            var PurchaseItem = new PurchaseItem
            {
                Id = request.Id,
                ProductId = request.ProductId,
                PurchaseId = request.PurchaseId,
                UOM = (Core.UnitOfMeasure)request.UOM,
                Notes = request.Notes,
                Price = request.Price,
                Quantity = request.Quantity
            };

            _repo.UpdatePurchaseItem(PurchaseItem);
            await _repo.Save();
            return Ok(PurchaseItem);
        }
    }
}
