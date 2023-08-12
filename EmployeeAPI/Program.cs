using BusinessServices.Layer.Interface;
using BusinessServices.Layer.Concrete;
using DataAcess.Layer.Concrete;
using DataAcess.Layer.Interface;
using EmployeesDb.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EmployeesDbContext>();
builder.Services.AddScoped<IEmployeeRepository<Employee>, EmployeeRepository<Employee>>();
builder.Services.AddScoped<IEmployeeBusiness<Employee>, EmployeeBusiness<Employee>>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
