namespace FinalWorkConnectProject.Infrastructure.Data
{
    /// <summary>
    /// Provides database connection using Dapper
    /// </summary>
    public class DapperContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Creates and returns a SQL database connection
        /// </summary>
        public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
    }
}
