using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Account;
using F1Cafe.Services.Contracts;
using F1Cafe.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace F1Cafe.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly UserManager<F1CafeUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<F1CafeUser> signInManager;
        private readonly ILogger<UserService> logger;

        public UserService(F1CafeDbContext dbContext,
            IMapper mapper,
            UserManager<F1CafeUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<F1CafeUser> signInManager,
            ILogger<UserService> logger)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<SignInResult> Login(LoginInputModel inputModel)
        {
            var result = await this.signInManager
                .PasswordSignInAsync(inputModel.UserName, inputModel.Password, inputModel.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                this.logger.LogInformation("User logged in.");

                return SignInResult.Success;
            }

            return result;
        }

        public async void Logout()
        {
            await this.signInManager.SignOutAsync();
            this.logger.LogInformation("User logged out.");
        }

        public async Task<IdentityResult> Register(RegisterInputModel inputModel)
        {
            var user = new F1CafeUser
            {
                UserName = inputModel.UserName,
                FirstName = inputModel.FirstName,
                LastName = inputModel.LastName,
                Email = inputModel.Email
            };

            var registerUserResult = await this.userManager.CreateAsync(user, inputModel.Password);

            if (registerUserResult.Succeeded)
            {
                this.logger.LogInformation("User created a new account with password.");

                await AssingRoleToUser(user);

                await this.signInManager.SignInAsync(user, isPersistent: false);

                return IdentityResult.Success;
            }

            return registerUserResult;
        }

        private async Task AssingRoleToUser(F1CafeUser user)
        {
            if (this.userManager.Users.Count() > 1)
            {
                await this.userManager.AddToRoleAsync(user, GlobalConstants.UserRoleName);
            }
            else
            {
                await this.userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
            }
        }
    }
}
