using Microsoft.EntityFrameworkCore;
using ContactManagement.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
string sqlConnection = builder.Configuration.GetConnectionString("MariaDB");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
          options.UseMySql(sqlConnection,
                ServerVersion.AutoDetect(sqlConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
