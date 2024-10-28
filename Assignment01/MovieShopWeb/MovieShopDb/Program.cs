using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using Infrastruture.Data; 
using Infrastruture.Repositories; 
using Infrastruture.Services; 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the DbContext with SQL Server
builder.Services.AddDbContext<MovieShopDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDb"));
});

// Register repositories and services
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IGenreService, GenreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); 
}

app.UseHttpsRedirection(); 
app.UseStaticFiles(); 

app.UseRouting();

app.UseAuthorization(); 

// Configure default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); 