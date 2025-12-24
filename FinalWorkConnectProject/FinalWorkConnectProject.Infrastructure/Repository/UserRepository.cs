namespace FinalWorkConnectProject.Infrastructure.Repository
{
    /// <summary>
    /// Handles user-related database operations using Dapper
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a user by their unique identifier
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>User entity if found; otherwise null</returns>
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            const string query = @"
                SELECT  UserId, UserName, Email, Password, MobileNo, Location
                FROM Users WHERE UserId = @UserId";

            using IDbConnection connection = _context.CreateConnection();

            return await connection.QueryFirstOrDefaultAsync<User>(query, new { UserId = userId });
        }
    }
}
