using Microsoft.EntityFrameworkCore;
using PimUrbanGreen.Data;
using PimUrbanGreen.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar o repositório como serviço
builder.Services.AddScoped<UserRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}"
);

app.Run();
