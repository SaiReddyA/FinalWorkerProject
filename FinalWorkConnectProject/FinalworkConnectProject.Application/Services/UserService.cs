using AutoMapper;
using FinalWorkConnectProject.Application.DTOs;
using FinalWorkConnectProject.Application.Interfaces;
using FinalWorkConnectProject.Domain.Interface;

namespace FinalWorkConnectProject.Application.Services
{
    /// <summary>
    /// Provides user-related business operations
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the UserService class
        /// </summary>
        /// <param name="userRepository">Repository used to retrieve user data</param>
        /// <param name="mapper">AutoMapper instance for entity to DTO mapping</param>
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves user details based on the provided user identifier
        /// </summary>
        /// <param name="userId">Unique identifier of the user</param>
        /// <returns>
        /// Returns <see cref="UserDto"/> if the user exists; otherwise, null
        /// </returns>
        public async Task<UserDto?> GetUserByIdAsync(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            return user == null ? null : _mapper.Map<UserDto>(user);
        }
    }
}
