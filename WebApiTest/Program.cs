using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Writers;
using System.Net;
using WebApiTest.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Recognition>(opt=>);

var app = builder.Build();
//app.Urls.Add("http://192.168.1.77:5001"); //Windows IP

//app.Urls.Add("http://192.168.1.52:5001"); //Ubuntu IP

//app.Urls.Add("http://127.0.0.1:5001"); //Generic Local IP


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
