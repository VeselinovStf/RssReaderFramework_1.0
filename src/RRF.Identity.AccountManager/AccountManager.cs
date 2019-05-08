﻿using RRF.GuardValidator;
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
    public class AccountManager : IAccountManager<BaseIdentityModel>
    {
        private readonly IUserManagerUtility<BaseIdentityModel> userManagerUtility;
        private readonly ISignInManagerUtility<BaseIdentityModel> signInManagerUtility;

        public AccountManager(
            IUserManagerUtility<BaseIdentityModel> userManagerUtility,
            ISignInManagerUtility<BaseIdentityModel> signInManagerUtility)
        {
            this.userManagerUtility = userManagerUtility;
            this.signInManagerUtility = signInManagerUtility;
        }
        public async Task<bool> AddToRole(BaseIdentityModel user, string role)
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

        public async Task<bool> PasswordSignInAsync(string email, string password, bool rememberME, bool lockoutOnFailure = true)
        {
            try
            {
                var result = await this.signInManagerUtility.PasswordSignInAsync(email,  password,  rememberME,  lockoutOnFailure);

                return true;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Can't Sign in");
            }
        }

        public async Task<bool> Register(string email, string userName, string password)
        {
            Validator.StringIsNullOrEmpty(email);
            Validator.StringIsNullOrEmpty(userName);
            Validator.StringIsNullOrEmpty(password);

            var user = new BaseIdentityModel { UserName = userName, Email = email };

            try
            {
                var result = await this.userManagerUtility.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {

                throw new ArgumentException("Can't register user");
            }
                              
        }

      

        public async Task<bool> SignInAsync(BaseIdentityModel user, bool isPersistent = false)
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
    }
}