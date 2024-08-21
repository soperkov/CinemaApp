using CinemaApp.Components;
using CinemaApp.Models;
using CinemaApp.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace CinemaApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CinemaContext") ??
            throw new InvalidOperationException("Connection string CinemaContext not found")));

            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<SeatService>();
            builder.Services.AddScoped<MovieService>();

            builder.Services.AddSingleton<LoggedInUserModel>();

            builder.Services.AddBlazorBootstrap();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
