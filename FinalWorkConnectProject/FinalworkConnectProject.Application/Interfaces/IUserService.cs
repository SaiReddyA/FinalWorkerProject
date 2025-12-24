namespace FinalWorkConnectProject.Application.Interfaces
{
    /// <summary>
    /// Defines application-level operations related to users
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves user details by unique user identifier
        /// </summary>
        /// <param name="userId">Unique identifier of the user</param>
        /// <returns>
        /// A <see cref="UserDto"/> containing user details if found;
        /// otherwise, <c>null</c>
        /// </returns>
        Task<UserDto?> GetUserByIdAsync(int userId);
    }
}
