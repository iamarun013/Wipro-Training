using Microsoft.EntityFrameworkCore;
using InventoryManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure database context
builder.Services.AddDbContext<InventoryManagementContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("InventoryManagementContext")
        ?? throw new InvalidOperationException("Connection string 'InventoryManagementContext' not found.")));

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // 🔁 Added for production security
}

app.UseHttpsRedirection(); // 🔁 Added to ensure HTTPS
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default route for MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
