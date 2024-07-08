using FoodApp.Data;
using FoodApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OrderDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectString"));
});

//using (var scope = builder.Services.CreateScope()) // Create a scope
//{
//    var context = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
//    new SeedDb().Seed(context); // Call Seed method
//}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PizzaModels}/{action=Index}/{id?}");


//using (var scope =Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetRequiredService<OrderDbContext>();
//    new SeedDb().Seed(context);
//}
// this is add or prefilling the database

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<OrderDbContext>();   
    new SeedDb().Seed(context); 
}

app.Run();
