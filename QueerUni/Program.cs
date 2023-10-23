using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QueerUni.Models;
using Microsoft.AspNetCore.Identity;

namespace QueerUni
{
    class Program
    {
     static void Main(string[] args)
    {

      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<QueerUniContext>(
        dbContextOptions => dbContextOptions
          .UseMySql(
            builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
          )
        )
      );

      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<QueerUniContext>()
               .AddDefaultTokenProviders();
               

builder.Services.Configure<IdentityOptions>(options =>
              {options.Password.RequireDigit = true;
              options.Password.RequireLowercase = true;
              options.Password.RequireNonAlphanumeric = true;
              options.Password.RequireUppercase = true;
              options.Password.RequiredLength = 6;
              options.Password.RequiredUniqueChars = 1;
    });
  


      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthentication();
     app.UseAuthorization();

      app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}");

      app.Run();
    }
     
    }
}
// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddControllersWithViews();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

// app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run();
