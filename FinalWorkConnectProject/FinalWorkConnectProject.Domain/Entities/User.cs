using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkConnectProject.Domain.Entities
{
    /// <summary>
    /// gets and sets the user details
    /// </summary>
    public class User
    {
        public int UserId { get; set; } = 0;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public long MobileNo { get; set; } 
        public string Location { get; set;} = string.Empty;    
    }
}
