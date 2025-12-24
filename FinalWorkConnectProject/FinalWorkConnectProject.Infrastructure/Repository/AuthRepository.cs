using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalWorkConnectProject.Domain.Entities;
using FinalWorkConnectProject.Domain.Interface;

namespace FinalWorkConnectProject.Infrastructure.Repository
{
    public class AuthRepository: IAuthRepository
    {
        
        Task<User> IAuthRepository.LoginDetails()
        {
            throw new NotImplementedException();
        }
    }
}
