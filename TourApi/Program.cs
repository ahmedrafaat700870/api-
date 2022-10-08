
using Microsoft.EntityFrameworkCore;
using ReporsitriesPatternWithUnitOfWork.Core.Repositories;
using RepositoriesPatternWithUnitOfWork.EF.Models;
using RepositoriesPatternWithUnitOfWork.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient(typeof(IRepositories<>), typeof(ClsRepositories<>));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(option =>
{
    option.AllowAnyHeader();
    option.AllowAnyMethod();
    option.AllowAnyOrigin();
});
app.UseAuthorization();

app.MapControllers();

app.Run();
