using Ardalis.ApiEndpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Microsoft.Data.SqlClient;
using RepoDb;
using InventoryManagement.Shared.Products;

namespace InventoryManagement.Api.Endpoints.Products
{
    public class GetAll : BaseAsyncEndpoint.WithoutRequest.WithResponse<List<Product>>
    {
        [HttpGet("/products/all")]
        public override async Task<ActionResult<List<Product>>> HandleAsync(CancellationToken cancellationToken = default)
        {

            using var connection = new SqlConnection(@"Server =.\; Integrated Security = True; Database = InventoryManagementDB");

            var sql = @"SELECT 
                           p.Id
                          ,p.Name
                          ,p.Brand
                          ,p.Description
                          ,pc.Name AS ProductCategory
                      FROM [dbo].[Products] p
                      JOIN [dbo].[ProductCategories] pc
                      ON p.[ProductCategoryId] = pc.[Id]
                      ORDER BY pc.Name, p.Name;";
            var Products = await connection.ExecuteQueryAsync<ProductListResponse>(sql, cancellationToken: cancellationToken);
            return Ok(Products);
        }
    }
}
