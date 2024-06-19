using Microsoft.AspNetCore.Identity;

namespace Micro.Services.AuthAPI.Models
{
    //defalt user is IdentityUser 
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
