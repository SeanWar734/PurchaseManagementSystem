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
    public class Create : BaseAsyncEndpoint.WithRequest<CreatePurchaseRequest>.WithoutResponse
    {
        private readonly IPurchaseRepository _repo;
        public Create(IPurchaseRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/purchases")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreatePurchaseRequest request, CancellationToken cancellationToken = default)
        {
            var Purchase = new Purchase
            {
                Id = request.Id,
                VendorId = request.VendorId,
                Date = request.Date,
                ReferenceNumber = request.ReferenceNumber
            };
            await _repo.Add(Purchase);
            await _repo.Save();
            return Ok(Purchase);
        }
    }
}
