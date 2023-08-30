using SpendingAnalyticsSystem.API.DIConfiguration;

namespace SpendingAnalyticsSystem.API
{
    public static class Configuration
    {

        public static void DoCustomConfigurations(WebApplicationBuilder builder)
        {
            builder.Services.Configure<PositionOptions>(
                builder.Configuration.GetSection(PositionOptions.ConfigSectionName));

            builder.Services.Configure<DbOptions>(
                builder.Configuration.GetSection(DbOptions.ConfigSectionName));
        }
    }
}
