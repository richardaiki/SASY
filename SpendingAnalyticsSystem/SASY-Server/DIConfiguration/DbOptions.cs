namespace SpendingAnalyticsSystem.API.DIConfiguration
{
    public class DbOptions
    {
        public const string ConfigSectionName = "ConnectionStrings";

        public string HomeSql { get; set; } = string.Empty;
    
    }
}
