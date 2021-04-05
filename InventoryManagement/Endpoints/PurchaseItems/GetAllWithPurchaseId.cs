using Ardalis.ApiEndpoints;
using InventoryManagement.Shared.PurchaseItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.PurchaseItems
{
    public class GetAllWithPurchaseId : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<List<PurchaseItemListResponse>>
    {

        [HttpGet("/purchaseitems/{id}")]
        public override async Task<ActionResult<List<PurchaseItemListResponse>>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = InventoryManagementDB");

            var sql = @"SELECT
	                           pi.[Id]
                              ,pu.[Id] AS PurchaseId
                              ,pr.[Id] AS ProductId
                              ,pu.[ReferenceNumber] AS PurchaseReferenceNumber
                              ,pr.[Name] AS ProductName
                              ,pi.[UOM]
                              ,pi.[Quantity]
                              ,pi.[Price]
                              ,pi.[Notes]
                          FROM [dbo].[PurchaseItems] pi
                          JOIN [dbo].[Products] pr
                          ON pi.ProductId = pr.Id
                          JOIN [dbo].[Purchases] pu
                          ON pi.PurchaseId = pu.Id
                          WHERE pu.[Id] = @Id;";
            var PurchaseItems = await connection.ExecuteQueryAsync<PurchaseItemListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(PurchaseItems);
        }
    }
}
