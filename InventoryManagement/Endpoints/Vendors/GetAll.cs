using Ardalis.ApiEndpoints;
using InventoryManagement.Shared.Vendors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Vendors
{
    public class GetAll : BaseAsyncEndpoint.WithoutRequest.WithResponse<List<VendorListResponse>>
    {
        [HttpGet("/vendors/all")]
        public override async Task<ActionResult<List<VendorListResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = InventoryManagementDB");

            var sql = @"SELECT 
                             v.[Id]
                            ,v.[Name]
                        FROM [dbo].[Vendors] v";
            var Vendors = await connection.ExecuteQueryAsync<VendorListResponse>(sql, cancellationToken: cancellationToken);
            return Ok(Vendors);
        }
    }
}
