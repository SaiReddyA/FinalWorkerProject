using FinalWorkConnectProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkConnectProject.Domain.Interface
{
    /// <summary>
    /// Authentication login details
    /// </summary>
    public interface IAuthRepository
    {
        /// <summary>
        /// it validate the user
        /// </summary>
        /// <returns> the user data </returns>
        /// <see cref= "User">
        Task<User> LoginDetails();
      
    }
}
