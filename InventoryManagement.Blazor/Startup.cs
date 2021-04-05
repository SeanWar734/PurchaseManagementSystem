using Blazored.Modal;
using InventoryManagement.Blazor.Data;
using InventoryManagement.Blazor.Data.Products;
using InventoryManagement.Blazor.Data.PurchaseItems;
using InventoryManagement.Blazor.Data.Purchases;
using InventoryManagement.Blazor.Data.Vendors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IProductService, ProductService>(client => client.BaseAddress = new Uri("https://localhost:44378/"));
            services.AddHttpClient<IPurchaseService, PurchaseService>(client => client.BaseAddress = new Uri("https://localhost:44378/"));
            services.AddHttpClient<IPurchaseItemService, PurchaseItemService>(client => client.BaseAddress = new Uri("https://localhost:44378/"));
            services.AddHttpClient<IVendorService, VendorService>(client => client.BaseAddress = new Uri("https://localhost:44378/"));
            services.AddRazorPages();
            services.AddBlazoredModal();
            services.AddServerSideBlazor();
            services.AddSingleton<ProductService>();
            services.AddSingleton<PurchaseService>();
            services.AddSingleton<PurchaseItemService>();
            services.AddSingleton<VendorService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
