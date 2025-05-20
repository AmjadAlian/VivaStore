using AutoMapper;
using Landing.DAL.Models;
using Landing.PL.Helpers;
using Landing.PL.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Security.Claims;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace Landing.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public AccountController(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager, ApplicationDbContext context,IMapper mapper )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
			this.context = context;
			this.mapper = mapper;
		}


        public IActionResult MyAccount()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Register(RegisterVM vm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = vm.UserName,
                    Email = vm.Email,
                    
                
                };
                
              var result =  await userManager.CreateAsync(user, vm.Password);

                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmEmailLink = Url.Action("ConfirmEmail", "Account", new {userId = user.Id  , token=token}, protocol:HttpContext.Request.Scheme);
                    var email = new Email
                    {
                        Recivers = user.Email,
                        Subject = "Confirm Email",
                        Body = $"Confirm Your Email: {confirmEmailLink}"
                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(Login));
                }
            }

           return View(vm);
        }

        public async Task <IActionResult> ConfirmEmail(string userId,string token)
        {
            if(userId == null || token == null)
            {
                return RedirectToAction("Error","Home");
            }
            var user = await userManager.FindByIdAsync(userId); 
            if(user is not null)
            {
               var result = await userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }
            }
            return RedirectToAction("Error", "Home");
        }
        public IActionResult Login() {
        
        return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if(ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vm.Email);
                if(user != null)
                {
                    var checkPassword = await userManager.CheckPasswordAsync(user, vm.Password);
                    if (checkPassword)
                    {
                        var result = await signInManager.PasswordSignInAsync(user,vm.Password,vm.RememberMe,true);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index","Home");
                        }

                    }
                }

               
            }

            return View(vm);
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public async Task<IActionResult> SendPasswordUrl(ForgotPasswordVM vm) {


            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vm.Email);
                if (user != null)
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);
                    var resetPasswordUrl = Url.Action("ResetPassword", "Account", new { email=vm.Email , token = token },"https", "localhost:7182");
                    var email = new Email
                    {
                        Subject = vm.Email,
                        Recivers = vm.Email,
                        Body = resetPasswordUrl,

                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(Login));
                }
            }

            return View(nameof(ForgotPassword));

        }
        public IActionResult ResetPassword(string email,string token)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM vm)
        {
            var user = await userManager.FindByEmailAsync(vm.Email);
            if(user != null)
            {
                var result = await userManager.ResetPasswordAsync(user,vm.Token, vm.NewPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }
            }

            return View(vm);
        }

		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index","Home");
		}


	}
}
