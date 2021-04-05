using Ardalis.ApiEndpoints;
using InventoryManagement.Shared.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Api.Endpoints.Products
{
    public class Get : BaseAsyncEndpoint.WithRequest<Guid>.WithResponse<ProductListResponse>
    {
        [HttpGet("/products/{id}")]

        public override async Task<ActionResult<ProductListResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
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
                      WHERE p.Id = @Id;";
            var purchase = await connection.ExecuteQueryAsync<ProductListResponse>(sql, new { Id = id }, cancellationToken: cancellationToken);
            return Ok(purchase.FirstOrDefault());

        }

    }
}