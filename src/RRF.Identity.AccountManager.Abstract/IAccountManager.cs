using System;
using System.Threading.Tasks;

namespace RRF.Identity.AccountManager.Abstract
{
    public interface IAccountManager<T>
    {
        Task<T> Register(string email, string userName, string password);

        Task<bool> AddToRoleAsync(T user, string role);

        Task<bool> SignInAsync(T user, bool isPersistent = false);

        Task<bool> PasswordSignInAsync(string email, string password, bool rememberME, bool lockoutOnFailure = true);

        Task<bool> SignOutAsync();
    }
}