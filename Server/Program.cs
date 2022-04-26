using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using PizzaPlace.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PizzaPlaceDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("PizzaPlaceDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();


//public partial class Program
//{

//    public static void Main(string[] args)
//        => CreateHostBuilder(args).Build().Run();

//    // EF Core uses this method at design time to access the DbContext
//    public static IHostBuilder CreateHostBuilder(string[] args)
//        => Host.CreateDefaultBuilder(args)
//            .ConfigureWebHostDefaults(
//                webBuilder => webBuilder.UseStartup<Startup>());
//}

//public class Startup
//{
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddDbContext<ApplicationDbContext>();
//    }

//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//    }
//}

//public class ApplicationDbContext : DbContext
//{
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//        : base(options)
//    {
//    }
//}