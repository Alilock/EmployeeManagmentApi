using EmployeeManagement.DAL;
using EmployeeManagement.Entities.Identity;
using EmployeeManagement.Repositories.UnitOfWork.Implementation;
using EmployeeManagement.Repositories.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDb>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDb>();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
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
