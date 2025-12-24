namespace FinalWorkConnectProject.Application.DTOs
{
    /// <summary>
    /// Data Transfer Object representing user information
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Unique identifier of the user
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Full name of the user
        /// </summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Email address of the user
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Mobile phone number of the user
        /// </summary>
        public long MobileNo { get; set; }

        /// <summary>
        /// Location or city of the user
        /// </summary>
        public string Location { get; set; } = string.Empty;
    }
}
