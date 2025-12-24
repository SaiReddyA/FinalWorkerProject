using FinalWorkConnectProject.Domain.Entities;

namespace FinalWorkConnectProject.Domain.Interface
{
    /// <summary>
    /// Defines data access operations related to users
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Retrieves a user by their unique identifier
        /// </summary>
        /// <param name="userId">Unique identifier of the user</param>
        /// <returns>
        /// Returns a <see cref="User"/> if found; otherwise, null
        /// </returns>
        Task<User?> GetUserByIdAsync(int userId);
    }
}
