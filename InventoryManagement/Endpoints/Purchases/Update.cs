using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using InventoryManagement.Shared.Purchases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Purchases
{
    public class Update : BaseAsyncEndpoint.WithRequest<UpdatePurchaseRequest>.WithoutResponse
    {
        private readonly IPurchaseRepository _repo;

        public Update(IPurchaseRepository repo)
        {
            _repo = repo;
        }

        [HttpPut("/purchases/{id}")]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdatePurchaseRequest request, CancellationToken cancellationToken = default)
        {

            var Purchase = new Purchase
            {
                Id = request.Id,
                ReferenceNumber = request.ReferenceNumber,
                VendorId = request.VendorId,
                Date = request.Date
            };

            _repo.UpdatePurchase(Purchase);
            await _repo.Save();
            return Ok(Purchase);
        }
    }
}
