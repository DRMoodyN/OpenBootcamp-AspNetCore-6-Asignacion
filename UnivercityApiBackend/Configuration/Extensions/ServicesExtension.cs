using System;

namespace UnivercityApiBackend.Configuration.Extensions
{
    public static class ServicesExtension
    {
        public static void ConfigureAppLogicContext(this IServiceCollection services,
         IConfiguration configuration)
        {
            services.AddDbContext<UnivercityContext>(sql =>
            {
                sql.UseSqlServer(configuration.GetConnectionString("AppDataLogic"));
            });
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWord, UnitOfWord>();
        }

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IServicesManager, ServicesManager>();
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(iss =>
            {
                // Por ahorita esta bien con los valores predeterminados
            });
        }

        //CORS(Cross-Origin Resource Sharing)
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(cors =>
            {
                cors.AddPolicy("CorsPolicy", builder =>
                {
                    // Podemos usar WithOrigins("https://example.com") permite solo request de esa fuente
                    builder.AllowAnyOrigin() // Permite solicitudes de cualquier fuente
                    // Permite todos los metodos http
                    // WithMethods("POST", "GET") que solo permitirá métodos HTTP específicos.
                    .AllowAnyMethod()
                    // WithHeaders("accept", "contenttype") para permitir solo encabezados específicos.
                    .AllowAnyHeader();
                });
            });
        }
    }
}
