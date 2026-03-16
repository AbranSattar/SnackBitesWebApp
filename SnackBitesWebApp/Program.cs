using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SnackBitesWebApp.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SnackBitesWebAppContextConnection") ?? throw new InvalidOperationException("Connection string 'SnackBitesWebAppContextConnection' not found.");;

builder.Services.AddDbContext<SnackBitesWebAppContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SnackBitesWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SnackBitesWebAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

//To create first commit for injecting identity. ඞ 
app.Run();
