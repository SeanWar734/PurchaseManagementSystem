using Ardalis.ApiEndpoints;
using InventoryManagement.Shared.ProductCategories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.ProductCategories
{
    public class GetAll : BaseAsyncEndpoint.WithoutRequest.WithResponse<List<ProductCategoryListResponse>>
    {
        [HttpGet("/productcategories/all")]
        public override async Task<ActionResult<List<ProductCategoryListResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = InventoryManagementDB");

            var sql = @"SELECT 
                             pc.[Id]
                            ,pc.[Name]
                        FROM [dbo].[ProductCategories] pc";
            var ProductCategories = await connection.ExecuteQueryAsync<ProductCategoryListResponse>(sql, cancellationToken: cancellationToken);
            return Ok(ProductCategories);
        }
    }
}
