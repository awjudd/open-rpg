using Microsoft.EntityFrameworkCore;
using OpenRPG.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationContext>(
    opt =>
    {
        opt.UseSqlServer()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        if (builder.Environment.IsDevelopment())
        {
            opt.EnableSensitiveDataLogging();
        }
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
