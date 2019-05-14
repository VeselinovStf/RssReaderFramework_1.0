using RRF.EFModels;
using RRF.GuardValidator;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityUtility.SignInManagerUtility.Abstract;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RRF.Identity.AccountManager
{
    public class AccountManager : IAccountManager<Client>
    {
        private readonly IUserManagerUtility<Client> userManagerUtility;
        private readonly ISignInManagerUtility<Client> signInManagerUtility;

        public AccountManager(
            IUserManagerUtility<Client> userManagerUtility,
            ISignInManagerUtility<Client> signInManagerUtility)
        {
            this.userManagerUtility = userManagerUtility;
            this.signInManagerUtility = signInManagerUtility;
        }

        public async Task<bool> AddToRoleAsync(Client user, string role)
        {
            try
            {
                await userManagerUtility.AddToRoleAsync(user, role);

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't add to role");
            }
        }

        public bool IsSignedIn(ClaimsPrincipal user)
        {
            return this.signInManagerUtility.IsSignedIn(user);
        }

        public async Task<bool> PasswordSignInAsync(string email, string password, bool rememberME, bool lockoutOnFailure = true)
        {
            try
            {
                var result = await this.signInManagerUtility.PasswordSignInAsync(email, password, rememberME, lockoutOnFailure);

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't Sign in");
            }
        }

        /// <summary>
        /// Creates new user
        /// </summary>
        /// <param name="email">User Email from Form</param>
        /// <param name="userName">User UserName from Form</param>
        /// <param name="password">User Password from form</param>
        /// <returns></returns>
        public async Task<Client> Register(string email, string userName, string password)
        {
            Validator.StringIsNullOrEmpty(email);
            Validator.StringIsNullOrEmpty(userName);
            Validator.StringIsNullOrEmpty(password);

            var user = new Client { UserName = userName, Email = email, APIKey = Guid.NewGuid() };

            try
            {
                var result = await this.userManagerUtility.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    return user;
                }

                throw new ArgumentException($"Account creation fails : {result.Errors}");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't register user");
            }
        }

        public async Task<Client> RetrieveUserAsync(ClaimsPrincipal user)
        {
            return await this.userManagerUtility.GetUserAsync(user);
        }

        public async Task<bool> SignInAsync(Client user, bool isPersistent = false)
        {
            try
            {
                await this.signInManagerUtility.SignInAsync(user, isPersistent: false);

                return true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't sign in with role");
            }
        }

        public async Task<bool> SignOutAsync()
        {
            try
            {
                await this.signInManagerUtility.SignOutAsync();

                return true;
            }
            catch (Exception)
            {
                throw new ArgumentException("Can't Sign out");
            }
        }

        public async Task<IList<string>> GetRolesAsync(Client user)
        {
            try
            {
                return await this.userManagerUtility.GetRolesAsync(user);
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Can't get role : " + ex.Message);
            }
        }
    }
}