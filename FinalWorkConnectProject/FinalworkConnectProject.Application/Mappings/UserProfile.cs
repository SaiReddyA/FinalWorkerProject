namespace FinalWorkConnectProject.Application.Mappings
{
    /// <summary>
    /// AutoMapper profile for mapping User domain entity to User data transfer object
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Initializes mappings related to User entity
        /// </summary>
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}