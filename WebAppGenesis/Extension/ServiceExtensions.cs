using Microsoft.EntityFrameworkCore;
using Layer.DATA;

namespace WebAppGenesis.Extension
{
    public static class ServiceExtensions
    {
        //["ConnectionStrings::sqlConnection"];

        static string stricon = @"Data Source=DESKTOP-S1KPBO3;Initial Catalog=TaskManagerDB;User ID=sa;Password=rossy2233;Application Name=MyApp";

        public static void ConfigureSqlContext(this IServiceCollection services,
                       IConfiguration configuration) =>
                            services.AddDbContext<TaskManagerDBContext>(opts =>
                                      opts.UseSqlServer(stricon));

    }
}
