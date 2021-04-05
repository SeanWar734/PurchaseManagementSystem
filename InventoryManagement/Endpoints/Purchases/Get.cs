using Ardalis.ApiEndpoints;
using InventoryManagement.Shared.Purchases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Purchases
{
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<PurchaseListResponse>
    {
        [HttpGet("/purchases/{id}")]

        public override async Task<ActionResult<PurchaseListResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = InventoryManagementDB");

            var sql = @"SELECT 
	                           p.[Id]
                              ,v.[Name] AS VendorName
                              ,v.[Id] AS VendorId
                              ,p.[Date]
                              ,p.[ReferenceNumber]
                          FROM [dbo].[Purchases] p
                          JOIN [dbo].[Vendors] v
                          ON p.VendorId = v.Id
                          WHERE p.Id = @Id;";
            var purchase = await connection.ExecuteQueryAsync<PurchaseListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(purchase.FirstOrDefault());

        }

    }
}