using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RRF.Web.ViewModels.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        //        private const string BASE_USER_ROLE = "NoRoleUser";

        //        private readonly ISignInManagerUtility<BaseUser> _signInManager;
        //        private readonly IUserManagerUtility<BaseUser> _userManager;
        //        private readonly ILoggerUtility<AccountController> _logger;
        //        private readonly IModelStateHandler _modelStateHandler;
        //        private readonly ILocalRedirector _localRedirector;

        //        public AccountController(
        //            IUserManagerUtility<BaseUser> userManager,
        //            ISignInManagerUtility<BaseUser> signInManager,
        //            ILoggerUtility<AccountController> logger,
        //            IModelStateHandler modelStateHandler,
        //            ILocalRedirector localRedirector

        //           )
        //        {
        //            _userManager = userManager;
        //            _signInManager = signInManager;
        //            _logger = logger;
        //            _modelStateHandler = modelStateHandler;
        //            _localRedirector = localRedirector;
        //        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            //if (ModelState.IsValid)
            //{
            //    var user = new BaseUser { UserName = model.Email, Email = model.Email };
            //    var result = await _userManager.CreateAsync(user, model.Password);

            //    await _userManager.AddToRoleAsync(user, BASE_USER_ROLE);
            //    if (result.Succeeded)
            //    {
            //        _logger.LogInformation("User created a new account with password.");

            //        await _signInManager.SignInAsync(user, isPersistent: false);
            //        return RedirectToLocal("RegisterRole", "Account", "RegisterRole");
            //    }

            //    this._modelStateHandler.AddError(result, ModelState);
            //}

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //        [Authorize]
        //        [HttpGet]
        //        public IActionResult RegisterRole(string returnUrl = null)
        //        {
        //            ViewData["ReturnUrl"] = returnUrl;
        //            var viewModel = new RegisterRoleModel();

        //            return View(viewModel);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> RegisterRole(RegisterRoleModel model, string returnUrl = null)
        //        {
        //            ViewData["ReturnUrl"] = returnUrl;

        //            //TODO: 01- Change here
        //            if (ModelState.IsValid)
        //            {
        //                var user = await _userManager.FindByEmailAsync(model.Email);

        //                await _userManager.RemoveFromRoleAsync(user, BASE_USER_ROLE);
        //                await _userManager.AddToRoleAsync(user, model.Role);

        //                var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);
        //                var claims = claimsPrincipal.Claims.ToList();

        //                var claimsPrinciple = new ClaimsIdentity(new List<Claim>() { claims.FirstOrDefault(c => c.Value == model.Role) });

        //                User.AddIdentity(new ClaimsIdentity(new List<Claim>() { claims.FirstOrDefault(c => c.Value == model.Role) }));

        //                _logger.LogInformation("User added to a role {0}", model.Role);

        //                return RedirectToAction("Index", "Common", new { area = "Common" });
        //            }

        //            return View(model);
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public async Task<IActionResult> Login(string returnUrl = null)
        //        {
        //            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        //            ViewData["ReturnUrl"] = returnUrl;
        //            return View();
        //        }

        //        [HttpPost]
        //        [AllowAnonymous]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                ViewData["ReturnUrl"] = returnUrl;
        //                // This doesn't count login failures towards account lockout
        //                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
        //                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
        //                if (result.Succeeded)
        //                {
        //                    var user = await _userManager.FindByEmailAsync(model.Email);
        //                    var roles = await _userManager.GetRolesAsync(user);

        //                    if (roles.Contains(BASE_USER_ROLE))
        //                    {
        //                        _logger.LogInformation("User logged in with no role.");

        //                        return RedirectToLocal("RegisterRole", "Account", "RegisterRole");
        //                    }

        //                    _logger.LogInformation("User logged in with role.");

        //                    return RedirectToLocal("Index", "Common", "Index", "Common");
        //                }

        //                if (result.IsLockedOut)
        //                {
        //                    _logger.LogWarning("User account locked out.");
        //                    return RedirectToPage("./Lockout");
        //                }
        //                else
        //                {
        //                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //                    return View(model);
        //                }
        //            }

        //            // If we got this far, something failed, redisplay form
        //            return View(model);
        //        }

        //        public async Task<IActionResult> Logout(string returnUrl = null)
        //        {
        //            await _signInManager.SignOutAsync();
        //            _logger.LogInformation("User logged out.");
        //            if (returnUrl != null)
        //            {
        //                return RedirectToLocal(returnUrl);
        //            }
        //            else
        //            {
        //                return View();
        //            }
        //        }

        //        public IActionResult AccessDenied()
        //        {
        //            return View();
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public IActionResult ExternalLogin()
        //        {
        //            return RedirectToLocal("Login");
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public IActionResult ForgotPassword()
        //        {
        //            return View();
        //        }

        //        [HttpPost]
        //        [AllowAnonymous]
        //        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                var user = await _userManager.FindByEmailAsync(model.Email);
        //                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
        //                {
        //                    // Don't reveal that the user does not exist or is not confirmed
        //                    return RedirectToAction(nameof(ForgotPasswordConfirmation));
        //                }

        //                // For more information on how to enable account confirmation and password reset please
        //                // visit https://go.microsoft.com/fwlink/?LinkID=532713

        //                return RedirectToAction(nameof(ForgotPasswordConfirmation));
        //            }

        //            return View(model);
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public IActionResult ForgotPasswordConfirmation()
        //        {
        //            return View();
        //        }

        //        [HttpGet]
        //        [AllowAnonymous]
        //        public IActionResult Lockout()
        //        {
        //            return View();
        //        }

        //        private IActionResult RedirectToLocal(string returnUrl, string controller = "Home", string action = "Index", string area = "")
        //        {
        //            return this._localRedirector.RedirectToLocal(this, Url, returnUrl, controller, action, area);
        //        }
    }
}