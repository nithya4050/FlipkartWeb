using FlipkartWeb;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FlipkartWeb.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
     .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddScoped<EmailService>();
// Add session services
builder.Services.AddDistributedMemoryCache(); // Required for session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Enable Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization();


//SQl Connection
var Connection = builder.Configuration.GetConnectionString("Jsconn");
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(Connection));



var app = builder.Build();

var supportedCultures = new[] { "en-US", "ta-IN" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("ta-IN")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
// Enable session
app.UseSession();
app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Authend}/{action=Registration}/{id?}");

// WWWroot access.
app.UseStaticFiles();



app.Run();









//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

