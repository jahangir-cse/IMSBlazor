using Application.DTO.Request.Identity;
using Application.DTO.Response.Identity;
using Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Identity
{
    public class AccountService(IAcccount acccount) : IAccountService
    {
        public async Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model) => await acccount.CreateUserAsync(model);
        public async Task<IEnumerable<GetUserWithClaimRersponseDTO>> GetUsersWithClaimsAsync() => await acccount.GetUsersWithClaimsAsync();
        public async Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model) => await acccount.LoginAsync(model);
        public async Task SetUpAsync() => await acccount.SetUpAsync();
        public async Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model) => await acccount.UpdateUserAsync(model);
    }
}
