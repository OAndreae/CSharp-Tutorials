namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating to xyz");
            _logger.LogWarning("xyz not found. Attempting to create xyz");
            _logger.LogError("Creation of xyz failed. Migration aborted");
        }
    }
}
