using System;

namespace UnivercityApiBackend.Configuration.Extensions
{
    public static class ServicesExtension
    {
        public static void ConfigureAppLogicContext(this IServiceCollection services,
         IConfiguration configuration)
        {
            services.AddDbContext<UniverstityDbContext>(sql =>
            {
                sql.UseSqlServer(configuration.GetConnectionString("AppDataLogic"));
            });
        }
    }
}
