using Microsoft.EntityFrameworkCore;
using SalesManagementWebMvcSystem.Data;
namespace SalesManagementWebMvcSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SalesManagementWebMvcSystemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SalesManagementWebMvcSystemContext") ?? throw new InvalidOperationException("Connection string 'SalesManagementWebMvcSystemContext' not found."),
                    builder => builder.MigrationsAssembly("SalesManagementWebMvcSystem")
                    ));


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<SeedingService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var seedingService = services.GetRequiredService<SeedingService>();
                    seedingService.Seed();
                }
                catch (Exception ex)
                {
                    // Log de erro (opcional)
                    Console.WriteLine($"Erro ao popular o banco de dados: {ex.Message}");
                }
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
