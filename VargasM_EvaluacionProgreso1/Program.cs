using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Globalization;
using VargasM_EvaluacionProgreso1.Data;

namespace VargasM_EvaluacionProgreso1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<VargasM_EvaluacionProgreso1Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("VargasM_EvaluacionProgreso1Context") ?? throw new InvalidOperationException("Connection string 'VargasM_EvaluacionProgreso1Context' not found.")));
           
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var cultureInfo = new CultureInfo("es-ES");
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            cultureInfo.NumberFormat.NumberDecimalSeparator = ".";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
