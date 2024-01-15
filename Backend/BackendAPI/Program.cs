using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opts =>
{
    opts.AddDefaultPolicy(options =>
    {
        options.WithOrigins("http://localhost:5173")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
// app.Use(async (context, next) =>
// {
//     if (context.Request.Method == "OPTIONS")
//     {
//         context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
//         context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, PATCH, DELETE, OPTIONS");
//         context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization, X-Requested-With");
//         
//     }
// await next(); 
// });

app.UseRouting();
app.UseCors();
app.MapControllers();

app.Run();
