using Microsoft.AspNetCore.Identity;
using RRF.EFModels;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityUtility.SignInManagerUtility.Abstract;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.IdentityUtility.SignInManagerUtility
{
    public class SignInManagerUtility : ISignInManagerUtility<Client>
    {
        private readonly SignInManager<Client> _signInManager;

        public SignInManagerUtility(SignInManager<Client> signInManager)
        {
            this._signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
        }

        public async Task SignInAsync(Client user, bool isPersistent)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
        }

        public async Task<SignInResult> PasswordSignInAsync(string email, string password, bool rememberMe, bool lockoutOnFailure)
        {
            return await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: lockoutOnFailure);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task RefreshSignInAsync(Client user)
        {
            await this._signInManager.RefreshSignInAsync(user);
        }

        public bool IsSignedIn(ClaimsPrincipal user)
        {
            return this._signInManager.IsSignedIn(user);
        }

        public async Task<ClaimsPrincipal> CreateUserPrincipalAsync(Client user)
        {
            return await this._signInManager.CreateUserPrincipalAsync(user);
        }
    }
}