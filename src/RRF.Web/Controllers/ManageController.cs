//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;

//using RRF.Web.ViewModels.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RentSystem.Web.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        //        private readonly ISignInManagerUtility<BaseUser> _signInManager;
        //        private readonly IUserManagerUtility<BaseUser> _userManager;
        //        private readonly ILoggerUtility<ManageController> _logger;

        //        public ManageController(
        //            IUserManagerUtility<BaseUser> userManager,
        //            ISignInManagerUtility<BaseUser> signInManager,
        //            ILoggerUtility<ManageController> logger
        //            )
        //        {
        //            _userManager = userManager;
        //            _signInManager = signInManager;
        //            _logger = logger;
        //        }

        //        [TempData]
        //        public string StatusMessage { get; set; }


        [HttpGet]
        public async Task<IActionResult> GetApiKey()
        {

            return View();
        }

        //        [HttpGet]
        //        public async Task<IActionResult> ChangePassword()
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var hasPassword = await _userManager.HasPasswordAsync(user);
        //            if (!hasPassword)
        //            {
        //                return RedirectToAction(nameof(HomeController.Error));
        //            }

        //            var model = new ChangePasswordViewModel() { StatusMessage = this.StatusMessage };
        //            return View(model);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        //        {
        //            if (!ModelState.IsValid)
        //            {
        //                return View(model);
        //            }

        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
        //            if (!changePasswordResult.Succeeded)
        //            {
        //                foreach (var error in changePasswordResult.Errors)
        //                {
        //                    ModelState.AddModelError(string.Empty, error.Description);
        //                }
        //                return View(model);
        //            }

        //            await _signInManager.RefreshSignInAsync(user);
        //            _logger.LogInformation("User changed their password successfully.");
        //            StatusMessage = "Your password has been changed.";

        //            return View(model);
        //        }

        //        [HttpGet]
        //        public async Task<IActionResult> DeletePersonalData()
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var model = new DeletePersonalDataViewModel()
        //            {
        //                RequirePassword = await _userManager.HasPasswordAsync(user)
        //            };

        //            return View(model);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeletePersonalData(DeletePersonalDataViewModel model)
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var requirePassword = await _userManager.HasPasswordAsync(user);
        //            if (requirePassword)
        //            {
        //                if (!await _userManager.CheckPasswordAsync(user, model.Password))
        //                {
        //                    ModelState.AddModelError(string.Empty, "Password not correct.");
        //                    return View(model);
        //                }
        //            }

        //            var result = await _userManager.DeleteAsync(user);
        //            var userId = await _userManager.GetUserIdAsync(user);
        //            if (!result.Succeeded)
        //            {
        //                throw new InvalidOperationException($"Unexpected error occurred deleteing user with ID '{userId}'.");
        //            }

        //            await _signInManager.SignOutAsync();

        //            _logger.LogInformation("User with ID '{UserId}' deleted themselves.", userId);

        //            return View(model);
        //        }

        //        [HttpPost]
        //        public async Task<IActionResult> DownloadPersonalData()
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            _logger.LogInformation("User with ID '{UserId}' asked for their personal data.", _userManager.GetUserId(User));

        //            // Only include personal data for download
        //            var personalData = new Dictionary<string, string>();
        //            var personalDataProps = typeof(BaseUser).GetProperties().Where(
        //                            prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));
        //            foreach (var p in personalDataProps)
        //            {
        //                personalData.Add(p.Name, p.GetValue(user)?.ToString() ?? "null");
        //            }

        //            Response.Headers.Add("Content-Disposition", "attachment; filename=PersonalData.json");
        //            return new FileContentResult(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(personalData)), "text/json");
        //        }

        //        [HttpGet]
        //        public async Task<IActionResult> Index()
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var model = new IndexViewModel()
        //            {
        //                Email = user.Email,
        //                IsEmailConfirmed = user.EmailConfirmed,
        //                PhoneNumber = user.PhoneNumber,
        //                Username = user.UserName,
        //                StatusMessage = StatusMessage
        //            };

        //            return View(model);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Index(IndexViewModel model)
        //        {
        //            if (!ModelState.IsValid)
        //            {
        //                return View(model);
        //            }

        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            var email = await _userManager.GetEmailAsync(user);
        //            if (model.Email != email)
        //            {
        //                var setEmailResult = await _userManager.SetEmailAsync(user, model.Email);
        //                if (!setEmailResult.Succeeded)
        //                {
        //                    var userId = await _userManager.GetUserIdAsync(user);
        //                    throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
        //                }
        //            }

        //            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        //            if (model.PhoneNumber != phoneNumber)
        //            {
        //                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, model.PhoneNumber);
        //                if (!setPhoneResult.Succeeded)
        //                {
        //                    var userId = await _userManager.GetUserIdAsync(user);
        //                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
        //                }
        //            }

        //            await _signInManager.RefreshSignInAsync(user);
        //            StatusMessage = "Your profile has been updated";
        //            return RedirectToAction(nameof(Index));
        //        }

        //        [HttpGet]
        //        public async Task<IActionResult> PersonalData()
        //        {
        //            var user = await _userManager.GetUserAsync(User);
        //            if (user == null)
        //            {
        //                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //            }

        //            return View();
        //        }
    }
}