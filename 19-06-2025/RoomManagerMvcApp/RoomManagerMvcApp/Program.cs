using Microsoft.EntityFrameworkCore;
using RoomManagerMvcApp.Data;
using RoomManagerMvcApp.Intra;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();/* opts =>
{
    opts.Filters.Add(new MyExceptionFilter());
});*/
builder.Services.AddHttpLogging();
builder.Services.AddLogging(b =>
{
    //b.ClearProviders();
    b.AddConsole();
    b.SetMinimumLevel(LogLevel.Error);
});

builder.Services.AddTransient<ErrorHandlerMiddleWare>();
string sqlbiulder=builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RoomManagerDbContext>(cfg =>
{
    cfg.UseSqlServer(sqlbiulder);
});

var app = builder.Build();
app.UseMiddleware<ErrorHandlerMiddleWare>();
app.UseHttpLogging();
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

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AddRoom}/{action=ViewRooms}/{id?}")
    .WithStaticAssets();


app.Run();
