using Layer.BLL.Customers;
using Layer.DATA.GRepository;
using Layer.DATA.Model;
using Layer.DATA;
using Microsoft.EntityFrameworkCore;
using WebAppGenesis.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.ConfigureSqlContext(builder.Configuration);
//builder.Services.AddDbContext<TaskManagerDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICityCommandService<City>, CityCommandService>();
builder.Services.AddScoped<ICountryCommandService<Country>, CountriesCommandService>();
builder.Services.AddScoped<ICustomerInformationCommandService<InfoCustomer>, CustomerCommandService>();
builder.Services.AddScoped<IServerCommandService<ServerInfo>, ServerInformationCommandService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
