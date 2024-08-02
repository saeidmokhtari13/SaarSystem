using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore;
using SaarSystem.Data;
using SaarSystem.Finance.Interfaces;
using SaarSystem.Finance.Services;
using SaarSystem.Procurement.Interfaces;
using SaarSystem.Procurement.Services;
using SaarSystem.Warehouse.Interfaces;
using SaarSystem.Warehouse.Services;
using SaarSystem.Production.Interfaces;
using SaarSystem.Production.Services;
using SaarSystem.Maintenance.Interfaces;
using SaarSystem.Maintenance.Services;
using SaarSystem.Sales.Interfaces;
using SaarSystem.Sales.Services;
using SaarSystem.General.Interfaces;
using SaarSystem.General.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
builder.Services.AddScoped<IInventoryItemService, InventoryItemService>();
builder.Services.AddScoped<IProductionOrderService, ProductionOrderService>();
builder.Services.AddScoped<IMaintenanceTaskService, MaintenanceTaskService>();
builder.Services.AddScoped<ISalesOrderService, SalesOrderService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();