using SpendingAnalyticsSystem.DIConfiguration;

namespace SpendingAnalyticsSystem
{
    public static class Configuration
    {

        public static void DoCustomConfigurations(WebApplicationBuilder builder)
        {

            var test = builder.Configuration.GetSection(PositionOptions.ConfigSectionName);

            builder.Services.Configure<PositionOptions>(
                test);
        }
    }
}
