using Ardalis.ApiEndpoints;
using InventoryManagement.Core;
using InventoryManagement.Shared.Vendors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Vendors
{
    public class Create : BaseAsyncEndpoint.WithRequest<CreateVendorRequest>.WithoutResponse
    {
        private readonly IVendorRepository _repo;
        public Create(IVendorRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("/vendors")]
        public override async Task<ActionResult> HandleAsync([FromBody] CreateVendorRequest request, CancellationToken cancellationToken = default)
        {
            var Vendor = new Vendor
            {
                Name = request.Name
            };
            await _repo.Add(Vendor);
            await _repo.Save();
            return Ok(Vendor);
        }
    }
}
