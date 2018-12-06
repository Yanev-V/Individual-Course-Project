using F1Cafe.Models.InputModels.Account;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface IUserService
    {
        Task<SignInResult> Login(LoginInputModel inputModel);

        void Logout();

        Task<IdentityResult> Register(RegisterInputModel inputModel);        
    }
}
