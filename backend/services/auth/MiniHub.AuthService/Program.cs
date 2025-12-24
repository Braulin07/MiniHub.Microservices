using Microsoft.EntityFrameworkCore;
using MiniHub.AuthService.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AuthDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("AuthDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
