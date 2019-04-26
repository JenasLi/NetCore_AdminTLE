using Jeans.WebCore.Models;
using Jeans.WebCore.Models.Account;
using System.Threading.Tasks;

namespace Jeans.WebCore.Services.Account
{
    public interface IUserService
    {
        Task<TableResponse<UserResponse>> GetUsers(int pageIndex, int pageSize, string nameOrEmpNo);

        Task<UserResponse> GetUserById(int id);
    }
}