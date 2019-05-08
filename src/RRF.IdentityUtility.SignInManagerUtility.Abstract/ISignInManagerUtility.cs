using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.IdentityUtility.SignInManagerUtility.Abstract
{
    public interface ISignInManagerUtility<T>
    {
        Task SignInAsync(T user, bool isPersistent);

        Task<SignInResult> PasswordSignInAsync(string email, string password, bool rememberMe, bool lockoutOnFailure);

        Task SignOutAsync();

        Task RefreshSignInAsync(T user);

        bool IsSignedIn(ClaimsPrincipal user);

        Task<ClaimsPrincipal> CreateUserPrincipalAsync(T user);
    }
}
