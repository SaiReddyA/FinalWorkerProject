namespace FinalWorkConnectProject.Infrastructure.Repository
{
    /// <summary>
    /// Handles authentication-related database operations
    /// </summary>
    public class AuthRepository : IAuthRepository
    {
        private readonly DapperContext _context;

        public AuthRepository(DapperContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Validates user credentials against the database
        /// </summary>
        public async Task<User?> LoginAsync(string email, string password)
        {
            const string query = @"
                SELECT UserId, UserName, Email, Password, MobileNo, Location FROM Users
                WHERE Email = @Email AND Password = @Password";

            using IDbConnection connection = _context.CreateConnection();

            return await connection.QueryFirstOrDefaultAsync<User>(
                query,
                new { Email = email, Password = password }
            );
        }
    }
}
