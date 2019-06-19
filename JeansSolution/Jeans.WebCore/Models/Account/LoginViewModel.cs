using System.ComponentModel.DataAnnotations;
using Jeans.WebCore.Resources;

namespace Jeans.WebCore.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "UserName", ResourceType = typeof(UserResource))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Common))]
        public string UserName { get; set; }

        [Display(Name = "Password", ResourceType = typeof(UserResource))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Common))]
        public string Password { get; set; }

        public bool HasLogin()
        {
            return UserName == "Jeans" && Password == "Jeans123456";
        }
    }
}
