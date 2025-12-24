namespace FinalWorkConnectProject.Application.DTOs
{
    /// <summary>
    /// Represents the authentication response returned after successful login
    /// </summary>
    public class AuthResponseDTO
    {
        /// <summary>
        /// JSON Web Token (JWT) used for authenticating subsequent API requests
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// Date and time when the authentication token expires
        /// </summary>
        public DateTime Expiry { get; set; }
    }
}
