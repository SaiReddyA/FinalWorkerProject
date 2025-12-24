using FinalWorkConnectProject.Domain.Entities;

namespace FinalWorkConnectProject.Domain.Interface
{
    /// <summary>
    /// Defines authentication-related data access operations
    /// </summary>
    public interface IAuthRepository
    {
        /// <summary>
        /// Validates user credentials
        /// </summary>
        /// <param name="email">User email</param>
        /// <param name="password">User password</param>
        /// <returns>Authenticated user or null</returns>
        Task<User?> LoginAsync(string email, string password);
    }
}
