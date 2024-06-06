
var builder = WebApplication.CreateBuilder(args);

// 1  Add services to the container.
//==============================
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ServicioConversionMoneda>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<ISaludo, SaludoEnAleman>();
//builder.Services.AddScoped<ISaludo, SaludoEnFrances>();

var app = builder.Build();

// 2Configure the HTTP request pipeline.
//=================================
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
