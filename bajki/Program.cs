using bajki.Models;
using bajki.Services;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ITaleServices,TaleServices>();

builder.Services.AddDbContext<MyDbContext>(
    option => {
        option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();

//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tales;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False