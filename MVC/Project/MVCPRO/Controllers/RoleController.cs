using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.VwModels;

namespace MVCPRO.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager) 
        {
            this.roleManager = roleManager;
        }
        
        [HttpGet]
        public IActionResult addRole()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addRole(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole();
                identityRole.Name = roleViewModel.role;
                IdentityResult identityResult = await roleManager.CreateAsync(identityRole);
                if (identityResult.Succeeded)
                    return View();
                else
                    ModelState.AddModelError("", "invalid Role Name");
            }
            return View(roleViewModel);
        }

    }
}
