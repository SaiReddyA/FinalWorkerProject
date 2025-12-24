using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkConnectProject.Application.DTOs
{
    /// <summary>
    /// Authentication response
    /// </summary>
    public class AuthResponseDTO
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Expiry { get; set; }

    }
}
