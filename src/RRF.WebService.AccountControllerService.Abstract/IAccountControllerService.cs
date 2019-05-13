using System;
using System.Threading.Tasks;

namespace RRF.WebService.AccountControllerService.Abstract
{
    public interface IAccountControllerService
    {
        Task<bool> RegistarPostCall(string email, string userName, string password);
    }
}