using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.VwModels;

namespace MVCPRO.Controllers
{
	public class AccountController : Controller
	{
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterModel registerModel)
		{
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
				appUser.UserName = registerModel.UserName;
				appUser.PasswordHash = registerModel.Password;
				appUser.address = registerModel.Address;

				IdentityResult identityResult = await userManager.CreateAsync(appUser,registerModel.Password);

				if (identityResult.Succeeded)
				{
					await signInManager.SignInAsync(appUser, false);
					return RedirectToAction("index","Course");
				}
				else
				{
                    foreach (var item in identityResult.Errors)
                    {
						ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(registerModel);
		}

		public async Task<IActionResult> logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("login");
		}

		[HttpGet]
		public async Task<IActionResult> login()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
				AppUser appuser = await userManager.FindByNameAsync(loginViewModel.UserName);
                if (appuser != null)
                {
					bool found = await userManager.CheckPasswordAsync(appuser, loginViewModel.Password);
					if (found) {
						List<Claim> claims = new List<Claim>();
						claims.Add(new Claim("address", appuser.address));
						await signInManager.SignInWithClaimsAsync(appuser, loginViewModel.rememberMe,claims);
						return RedirectToAction("index","Course");
					}
                }
				ModelState.AddModelError("", "UserName or Password is invalid");
            }
            return View(loginViewModel);
        }
    }
}
