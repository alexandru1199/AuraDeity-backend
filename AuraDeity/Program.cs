using DataAccess;
using Interfaces.Commands;
using Interfaces.Queries;
using Interfaces.Queries.Services;
using Logic.Commands;
using Logic.Queries;
using Logic.Queries.Services;
using Microsoft.EntityFrameworkCore;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped <IAuthenticationCommand,AuthenticationCommand>();
builder.Services.AddScoped <IAuthenticationQuery, AuthenticationQuery>();
builder.Services.AddScoped<IJwtQueryService, JwtQueryService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AuraDeityContext>(dbOptions =>
{
    dbOptions.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
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
