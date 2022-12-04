using booking;
using booking.Infrastructure.Reposytory.Implementations;
using booking.Infrastructure.Reposytory.Interfacies;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.RegisterDependesy();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

