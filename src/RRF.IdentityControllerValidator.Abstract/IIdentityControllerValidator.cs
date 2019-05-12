using System;
using System.Threading.Tasks;

namespace RRF.IdentityControllerValidator.Abstract
{
    public interface IIdentityControllerValidator
    {
        Task<bool> RegisterClientValidation(string email, string userName, string password);
    }
}