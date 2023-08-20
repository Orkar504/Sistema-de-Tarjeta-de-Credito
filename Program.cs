using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Tarjeta_de_Credito.Data;

const string galleta = "cookie"; // define el nombre de la cookie
const string LoginPath = "/Identity/Account/Login";
const string accessDenied = "/Identity/Account/AccessDenied";


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();



//Para genera las cookies y hacer las autenticaciones necesarias
builder.Services.AddAuthentication(galleta).AddCookie(galleta, options =>
{

    options.Cookie.Name = galleta;
    options.LoginPath = LoginPath; //Se utiliza la constante LoginPath por si requiere hacer cambios no se deba realizar en todos lados
    options.AccessDeniedPath = accessDenied;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5); // Si no se detecta actividad por n minutos se cierra la sesion
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Solicitudes",
        policy => policy.RequireClaim("Departamento", "S")); //Se utiliza S para solicitudes


});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); //MiddleWare
app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});
app.Run();
