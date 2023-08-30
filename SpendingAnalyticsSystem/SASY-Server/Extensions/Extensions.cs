using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SpendingAnalyticsSystem.API.Extensions
{
    public static class Extensions
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {

            static void ConfigureSqlOptions(SqlServerDbContextOptionsBuilder sqlOptions)
            {
                sqlOptions.MigrationsAssembly(typeof(Program).Assembly.FullName);

                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 15,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
            }
            

            services.AddDbContext<AccountContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("HomeSql"), ConfigureSqlOptions);
                });

                return services;

            }
        }
    }

