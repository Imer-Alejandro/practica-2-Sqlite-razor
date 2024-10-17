using Microsoft.EntityFrameworkCore;
using WebGestionConsolas.Components;
using WebGestionConsolas.Data.Interface;
using WebGestionConsolas.Data;
using WebGestionConsolas.Models;
using WebGestionConsolas.Service.Interface;
using WebGestionConsolas.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurar el contexto de base de datos SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//servicios
builder.Services.AddScoped<IPersonajeService, PersonajeService>();
builder.Services.AddScoped<IPlataformaService, PlataformaService>();
builder.Services.AddScoped<IVideojuegoService, VideojuegoService>();

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
