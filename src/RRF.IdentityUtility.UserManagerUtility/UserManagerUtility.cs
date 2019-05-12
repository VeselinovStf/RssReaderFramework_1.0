using Microsoft.AspNetCore.Identity;
using RRF.EFModels;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.IdentityUtility.UserManagerUtility
{
    public class UserManagerUtility : IUserManagerUtility<Client>
    {
        private readonly UserManager<Client> _userManager;

        public UserManagerUtility(UserManager<Client> userManager)
        {
            this._userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task AddToRoleAsync(Client user, string baseRole)
        {
            await _userManager.AddToRoleAsync(user, baseRole);
        }

        public async Task<IdentityResult> CreateAsync(Client user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<Client> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<bool> IsEmailConfirmedAsync(Client user)
        {
            return await _userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<Client> GetUserAsync(ClaimsPrincipal user)
        {
            return await _userManager.GetUserAsync(user);
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            return this._userManager.GetUserId(user);
        }

        public async Task<bool> HasPasswordAsync(Client user)
        {
            return await _userManager.HasPasswordAsync(user);
        }

        public async Task<IdentityResult> ChangePasswordAsync(Client user, string oldPassword, string newPassword)
        {
            return await this._userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task<bool> CheckPasswordAsync(Client user, string password)
        {
            return await this._userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IdentityResult> DeleteAsync(Client user)
        {
            return await this._userManager.DeleteAsync(user);
        }

        public async Task<string> GetUserIdAsync(Client user)
        {
            return await this._userManager.GetUserIdAsync(user);
        }

        public async Task<string> GetEmailAsync(Client user)
        {
            return await this._userManager.GetEmailAsync(user);
        }

        public async Task<IdentityResult> SetEmailAsync(Client user, string email)
        {
            return await this._userManager.SetEmailAsync(user, email);
        }

        public async Task<string> GetPhoneNumberAsync(Client user)
        {
            return await this._userManager.GetPhoneNumberAsync(user);
        }

        public async Task<IdentityResult> SetPhoneNumberAsync(Client user, string phoneNumber)
        {
            return await this._userManager.SetPhoneNumberAsync(user, phoneNumber);
        }

        public string GetUserName(ClaimsPrincipal user)
        {
            return this._userManager.GetUserName(user);
        }

        public async Task<IList<string>> GetRolesAsync(Client user)
        {
            return await this._userManager.GetRolesAsync(user);
        }

        public async Task RemoveFromRoleAsync(Client userId, string baseRole)
        {
            await this._userManager.RemoveFromRoleAsync(userId, baseRole);
        }
    }
}