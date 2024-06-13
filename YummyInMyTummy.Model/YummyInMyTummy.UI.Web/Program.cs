using Microsoft.EntityFrameworkCore;
using YummyInMyTummy.Data.EfCore;
using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.UI.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

string conString = "Server=(localdb)\\mssqllocaldb;Database=YummyInMyTummy_TestDb;Trusted_Connection=true;TrustServerCertificate=true;";
var optionsBuilder = new DbContextOptionsBuilder<EfContext>();
optionsBuilder.UseSqlServer(conString);
optionsBuilder.UseLazyLoadingProxies();

builder.Services.AddScoped<IRepository>(x => new EfRepository(optionsBuilder.Options));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
