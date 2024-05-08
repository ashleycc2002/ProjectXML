using Layer.BLL.Customers;
using Layer.DATA;
using Layer.DATA.GRepository;
using Layer.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskManagerDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICityCommandService<City>, CityCommandService>();
builder.Services.AddScoped<ICountryCommandService<Country>, CountriesCommandService>();
builder.Services.AddScoped<ICustomerInformationCommandService<InfoCustomer>, CustomerCommandService>();
builder.Services.AddScoped<IServerCommandService<ServerInfo>, ServerInformationCommandService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
