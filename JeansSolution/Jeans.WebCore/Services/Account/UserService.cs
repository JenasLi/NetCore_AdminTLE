using Jeans.Http;
using Jeans.WebCore.Models;
using Jeans.WebCore.Models.Account;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Jeans.WebCore.Services.Account
{
    public class UserService : IUserService
    {
        private readonly IHttpClient _apiClient;
        private readonly string _remoteServiceBaseUrl;
        public UserService(IHttpClient httpClient)
        {
            _remoteServiceBaseUrl = "http://localhost:54756/api/users";
            _apiClient = httpClient;
        }

        public async Task<TableResponse<UserResponse>> GetUsers(int pageIndex, int pageSize, string nameOrEmpNo)
        {
            var paras = $"/getall?PageIndex={pageIndex}&PageSize={pageSize}&nameOrEmpNo={nameOrEmpNo}";

            var dataString = await _apiClient.GetStringAsync(_remoteServiceBaseUrl + paras);

            var response = JsonConvert.DeserializeObject<TableResponse<UserResponse>>(dataString);

            return response;
        }

        public async Task<UserResponse> GetUserById(int id)
        {
            string url = $"{ _remoteServiceBaseUrl}/{id}";

            var dataString = await _apiClient.GetStringAsync(url);

            var response = JsonConvert.DeserializeObject<UserResponse>(dataString);

            return response;
        }
    }
}
