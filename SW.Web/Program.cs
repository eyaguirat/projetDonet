using Microsoft.EntityFrameworkCore;
using SW.DataAccessLayer;
using SW.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Ajout du DBContext par injection de dépendance.
builder.Services.AddDbContext<StarWarsDBContext>(options =>
{
    // On précise au DBContexte qu'il devra utiliser SQLite et
    // se baser sur la chaine de connexion "SW" disponible dans le appsettings.json
    options.UseSqlite(builder.Configuration.GetConnectionString("SW"));
});
// Injection de dépendance du CitoyenRepository
builder.Services.AddScoped<CitoyenRepository>();
builder.Services.AddScoped<CitoyenService>();


builder.Services.AddScoped<EvenementAleatoireRepository>();
builder.Services.AddScoped<EvenementAleatoireService>();


// Injection de dépendance du DivisionCitoyen
//builder.Services.AddScoped<DivisionCitoyen>();

builder.Services.AddScoped<EspeceRepository>();
builder.Services.AddScoped<EspeceService>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Exemple : Appeler les événements aléatoires chaque jour
// Cela pourrait être dans un service planifié ou un travailleur de fond

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


